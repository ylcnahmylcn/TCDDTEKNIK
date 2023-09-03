using Business.Abstract;
using Castle.Components.DictionaryAdapter;
using Core.Business.BusinessRules;
using Core.Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaultManager : IFaultService
    {
        IFaultDal _faultDal;
        public FaultManager(IFaultDal faultDal)
        {
            _faultDal = faultDal;
        }

        public IResult Add(Fault fault)
        { //var result = CheckIfFaultNameExists(fault.Area);
            IResult result = BusinessRules.Run(CheckIfFaultNameExists(fault.Area),
                CheckIfFaultTechnicalBuilding(fault.TechnicalBuilding) , CheckIfFaultTeam(fault.Team));
            if (result != null)
            {
                return result;
            }
            _faultDal.Add(fault);
            return new SuccessResult("Arıza Kaydı Başarı ile eklendi");
        }

        public IResult Delete(int id)
        {
            var result = _faultDal.Get(f => f.FaultId == id);
            _faultDal.Delete(result);
            return new SuccessResult("Arıza kaydı Silindi");
        }

        public IDataResult<Fault> Get(int id)
        {
            return new SuccessDataResult<Fault>(_faultDal.Get(f => f.FaultId == id) , " Arıza listelendi");
        }

        public IDataResult<List<Fault>> Get(string name)
        {
            return new SuccessDataResult<List<Fault>>(_faultDal.GetAll(f => f.Area == name ), " Bölge İsimleri  listelendi");
        }

        public IDataResult<List<Fault>> GetAll()
        {
            return new SuccessDataResult<List<Fault>>(_faultDal.GetAll() , "Arıza Kayıtları Listeledi");
        }

        public IDataResult<List<FaultDetailDto>> GetFaultDetailDtos()
        {     
            return new SuccessDataResult<List<FaultDetailDto>>(_faultDal.GetFaultDetailDto());
        }
      
        public IResult Update(Fault fault)
        {
            _faultDal.Update(fault);
            return new SuccessResult("Arıza Kaydı Güncellendi");
        }
        private IResult CheckIfFaultNameExists(string area)
        {

            // if (area == "sorgun")
            // {
            //  return new SuccessResult("Bölge ismi geçerli");
            // }
            //return new ErrorResult("Bölge ismi geçersiz");
           List<string> city = new List<string>();
            city.Add("sivas"); city.Add("sorgun"); city.Add("kayaş"); city.Add("kırıkkale"); city.Add("yozgat");

            foreach (var r in city)
            {
                if (area==r)
                {
                    return new SuccessResult("Bölge ismi geçerli");
                }
            }
            return new ErrorResult("Bölge ismi geçersiz");
         
        }
        private IResult CheckIfFaultTechnicalBuilding(string technicalBuilding)
        {
            List<string> building = new List<string>();
            building.Add("TB205"); building.Add("TB213"); building.Add("TB223"); building.Add("TB232");
            building.Add("TB244"); building.Add("TB254"); building.Add("TB261"); building.Add("TB274");
            building.Add("TB286"); building.Add("TB298"); building.Add("TB310");
            

            foreach (var b in building)
            {
                if (technicalBuilding == b )
                {
                    return new SuccessResult("Teknik Bina İsmi Geçerli");
                }
            }
            return new ErrorResult("Teknik Bina İsmi Geçersiz");
        }   
        private IResult CheckIfFaultTeam(string team)
        {
            List<string> TeamSituation = new List<string>();
            TeamSituation.Add("Evet"); TeamSituation.Add("Hayır");
            foreach (var t in TeamSituation)
            {
                if (team == t)
                {
                    return new SuccessResult("Ekip Yönledirme Geçerli");
                }
            }
            return new ErrorResult("Ekip Yönledirme Geçersiz");
        }

        public IDataResult<List<FaultDetailDto>> GetFaultDetailDtosId(int ıd)
        {
            throw new NotImplementedException();
        }
    }
}
