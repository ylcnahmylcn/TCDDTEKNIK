using Core.Business.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IFaultService
    {
        IDataResult<List<Fault>> GetAll();
        IDataResult<Fault> Get(int id);
        IDataResult<List<Fault>> Get(string name);
        IResult Add(Fault fault);
        IResult Delete(int id);
        IResult Update(Fault fault);
        IDataResult<List<FaultDetailDto>> GetFaultDetailDtos();
        IDataResult<List<FaultDetailDto>> GetFaultDetailDtosId(int ıd);
    }
}
