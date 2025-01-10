using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.HttpLogging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalRecordManager : IRentalRecordService
    {
        IRentalRecordDal _rentalRecorddal;


        [ValidationAspect(typeof(RentalRecordValidation))]
        public IResult Add(RentalRecord rentalRecord)
        {
            _rentalRecorddal.Add(rentalRecord);
            return new SuccessResult(RentalRecordMessages.AddedSuccess);
        }

        public IResult Delete(RentalRecord rentalRecord)
        {
            _rentalRecorddal.Delete(rentalRecord);
            return new SuccessResult(RentalRecordMessages.DeletedSuccess);
        }

        [ValidationAspect(typeof(RentalRecordValidation))]
        public IResult Update(RentalRecord rentalRecord)
        {
            _rentalRecorddal.Add(rentalRecord);
            return new SuccessResult(RentalRecordMessages.UpdatedSuccess);
        }

        public IDataResult<List<RentalRecord>> GetAll()
        {
            return new SuccessDataResult<List<RentalRecord>>(RentalRecordMessages.AddedSuccess, _rentalRecorddal.GetAll());
        }

        public IDataResult<RentalRecord> GetById(int id)
        {
            return new SuccessDataResult<RentalRecord>(RentalRecordMessages.AddedSuccess, _rentalRecorddal.Get (p=>p.RentalId==id));
        }
    }
}
