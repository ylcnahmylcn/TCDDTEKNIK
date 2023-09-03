using Core.Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFaultOffService
    {
        IDataResult<List<FaultOff>> GetAll();
        IResult Add(FaultOff faultoff);
    }
}
