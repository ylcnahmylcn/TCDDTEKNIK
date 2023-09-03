using Business.Abstract;
using Core.Business.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaultOffManager : IFaultOffService
    {
        IFaultOffDal _faultoffDal;
        public FaultOffManager(IFaultOffDal faultoffDal)
        {
            _faultoffDal = faultoffDal;
        }

        public IResult Add(FaultOff faultoff)
        {
            _faultoffDal.Add(faultoff);
            return new SuccessResult("Arıza Kapatma Kayıdı Eklendi");
        }

        public IDataResult<List<FaultOff>> GetAll()
        {
            return new SuccessDataResult<List<FaultOff>>(_faultoffDal.GetAll(), "Arıza Kapatma  Kayıtları Listeledi");
        }
    }
}
