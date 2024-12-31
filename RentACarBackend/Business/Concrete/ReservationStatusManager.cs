using Business.Abstract;
using Business.Constract.Messages;
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
    public class ReservationStatusManager:IReservationStatusService
    {
        IReservationStatusDal _reservationStatusDal;

        public ReservationStatusManager(IReservationStatusDal reservationStatusDal)
        {
            _reservationStatusDal = reservationStatusDal;
        }

        public IResult Add(ReservationStatu reservationStatu)
        {
           _reservationStatusDal .Add(reservationStatu);
            return new SuccessResult(ReservationStatusMessages.AddedSuccess);
        }

        public IResult Delete(ReservationStatu reservationStatu)
        {
            _reservationStatusDal.Delete(reservationStatu);
            return new SuccessResult(ReservationStatusMessages.DeletedSuccess);
        }

        public IDataResult<ReservationStatu> Get(int id)
        {
            return new SuccessDataResult<ReservationStatu>(ReservationStatusMessages.GetByIdSuccess,_reservationStatusDal .Get (p=>p.ReservationStatuId==id));
        }

        public IDataResult<List<ReservationStatu>> GetAll()
        {
            return new SuccessDataResult<List<ReservationStatu>>(ReservationMessages.ListedSuccess, _reservationStatusDal .GetAll ());
        }

        public IResult Update(ReservationStatu reservationStatu)
        {
            _reservationStatusDal.Update(reservationStatu);
            return new SuccessResult(ReservationStatusMessages.UpdatedSuccess);
        }
    }
}
