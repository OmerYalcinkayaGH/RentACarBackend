using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add")]
        [ValidationAspect(typeof(CarValidation))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(CarMessages.AddedSuccess);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(CarMessages.DeletedSuccess);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(CarMessages.ListedSuccess, _carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(CarMessages.GetByIdSuccess, _carDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(CarMessages .ListedSuccess ,_carDal.GetCarDetail());
        }

        [ValidationAspect(typeof(CarValidation))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(CarMessages.UpdatedSuccess);
        }
    }
}
