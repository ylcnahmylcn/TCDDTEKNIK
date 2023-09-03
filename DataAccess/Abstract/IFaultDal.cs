using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface IFaultDal:IEntityRepository<Fault>
    {
        List<FaultDetailDto> GetFaultDetailDto();
    }
}
