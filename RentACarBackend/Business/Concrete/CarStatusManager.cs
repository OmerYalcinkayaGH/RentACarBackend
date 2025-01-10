using Business.Abstract;
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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarStatusManager : ICarStatusService
    {
        ICarStutusDal _carStatusdal;

        public CarStatusManager(ICarStutusDal carStatusDal)
        {
            _carStatusdal = carStatusDal;
        }


        [ValidationAspect(typeof(CarStatusValidation))]
        public IResult Add(CarStatus carStatus)
        {
            _carStatusdal.Add(carStatus);
            return new SuccessResult(CarStatusMessages.AddedSuccess);
        }       

        public IResult Delete(CarStatus carStatus)
        {
            _carStatusdal.Delete(carStatus);
            return new SuccessResult(CarStatusMessages.DeletedSuccess);
        }

        [ValidationAspect(typeof(CarStatusValidation))]
        public IResult Update(CarStatus carStatus)
        {
            _carStatusdal.Update(carStatus);
            return new SuccessResult(CarStatusMessages.UpdatedSuccess);
        }

        IDataResult<List<CarStatus>> ICarStatusService.GetAll()
        {
            return new SuccessDataResult<List<CarStatus>>(CarStatusMessages.ListedSuccess,_carStatusdal.GetAll());
        }

        IDataResult<CarStatus> ICarStatusService.GetById(int id)
        {
            return new SuccessDataResult<CarStatus>(CarStatusMessages.ListedSuccess, _carStatusdal.Get(p=>p.CarStatusId==id));
        }
    }
}
