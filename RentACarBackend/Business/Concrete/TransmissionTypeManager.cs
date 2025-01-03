using Business.Abstract;
using Business.Constract.Messages;
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
    public class TransmissionTypeManager : ITransmissionTypeService
    {
        ITransmissionTypeDal _transmissionTypeDal;
        public TransmissionTypeManager(ITransmissionTypeDal transmissionTypeDal)
        {
            _transmissionTypeDal = transmissionTypeDal;
        }
        [ValidationAspect(typeof(TransmissionTypeValidation))]
        public IResult Add(TransmissionType transmissionType)
        {
            _transmissionTypeDal.Add(transmissionType);
            return new SuccessResult(TransmissionTypeMessages.TransmissionTypeAddedSuccess);
        }

        public IResult Delete(TransmissionType transmissionType)
        { _transmissionTypeDal.Delete(transmissionType);
            return new SuccessResult(TransmissionTypeMessages.TransmissionTypeDeletedSuccess);
        }

        public IDataResult<List<TransmissionType>> GetAll()
        {
            return new SuccessDataResult<List<TransmissionType>>(TransmissionTypeMessages.TransmissionTypeListedSuccess,
                _transmissionTypeDal.GetAll());
        }

        public IDataResult<TransmissionType> GetById(int id)
        {
            return new SuccessDataResult<TransmissionType>(TransmissionTypeMessages.TransmissionTypeListedSuccess,
                _transmissionTypeDal.Get(p=>p.TransmissionTypeId ==id));
        }

        [ValidationAspect(typeof(TransmissionTypeValidation))]
        public IResult Update(TransmissionType transmissionType)
        {
            _transmissionTypeDal.Update(transmissionType);
            return new SuccessResult(TransmissionTypeMessages.TransmissionTypeUpdatedSuccess);
        }
    }
}
