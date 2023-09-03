using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfFaultDal : EfEntityRepositoryBase<Fault, TCDDContext>, IFaultDal
    {
        public List<FaultDetailDto> GetFaultDetailDto()
        {
            using (TCDDContext context = new TCDDContext())
            {
                var result = from a in context.Faults
                             join b in context.FaultOffs
                             on a.FaultEqualId equals b.FaultEqualId
                             select new FaultDetailDto
                             {
                                 Area = a.Area,
                                 TechnicalBuilding = a.TechnicalBuilding,
                                 FaultDate = a.FaultDate,
                                 FaultTime = a.FaultTime ,
                                 FaultDetail= a.FaultDetail,
                                 ArrivalDate = b.ArrivalDate,
                                 ArrivalTime = b.ArrivalTime ,
                                 StartTime = b.StartTime ,
                                 PersonelNumber = b.PersonelNumber,
                                 WorkDoneOnTheFault = b.WorkDoneOnTheFault ,
                                 SolutionAndCommet = b.SolutionAndCommet ,
                                 FaultStatus = b.FaultStatus 

                             };
                return result.ToList();
            }
        }
    }
}
