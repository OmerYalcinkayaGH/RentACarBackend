using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelTypeManager : IFuelTypeService
    {
        IFuelTypeDal _fuelTypeDal;
        public FuelTypeManager(IFuelTypeDal fuelTypeDal)
        {
            _fuelTypeDal = fuelTypeDal;                
        }
        [ValidationAspect(typeof(FuelTypeValidation))]
        public IResult Add(FuelType fuelType)
        {
            _fuelTypeDal.Add(fuelType);
            return new SuccessResult(FuelTypeMessages.AddedSuccess);
        }

        public IResult Delete(FuelType fuelType)
        {
            _fuelTypeDal.Delete(fuelType);
            return new SuccessResult(FuelTypeMessages.AddedSuccess);
        }

        public IDataResult<List<FuelType>> GetAll()
        {
           return new SuccessDataResult<List<FuelType>>(FuelTypeMessages.ListedSuccess,_fuelTypeDal.GetAll ());
        }

        public IDataResult<FuelType> GetById(int id)
        {
            return new SuccessDataResult<FuelType>(FuelTypeMessages.GetByIdSuccess,_fuelTypeDal .Get(p=>p.FuelTypeId ==id));
        }
       
        [ValidationAspect(typeof(CustomerValidation))]
        public IResult Update(FuelType fuelType)
        {
            _fuelTypeDal.Update(fuelType);
            return new SuccessResult(FuelTypeMessages .UpdatedSuccess);
        }
    }
}
