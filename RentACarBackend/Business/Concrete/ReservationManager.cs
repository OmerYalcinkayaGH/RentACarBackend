using Business.Abstract;
using Business.Constract.Messages;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager:IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public IResult Add(Reservation reservation)
        {
            _reservationDal.Add(reservation);
            return new SuccessResult (ReservationMessages.AddedSuccess );
        }

        public IResult Delete(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
            return new SuccessResult(ReservationMessages.DeletedSuccess);
        }

        public IDataResult<List<Reservation>> GetAll()
        {
            return new SuccessDataResult<List<Reservation>>(ReservationMessages.ListedSuccess,_reservationDal .GetAll());
        }

        public IDataResult<Reservation> GetByID(int id)
        {
            return new SuccessDataResult<Reservation>(ReservationMessages.GetByIdSuccess , _reservationDal.Get(p=>p.ReservationId==id));
        }

        public IResult Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
            return new SuccessResult(ReservationMessages.UpdatedSuccess);
        
    }
    }
}
