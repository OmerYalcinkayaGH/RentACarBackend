using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IReservationStatusService
    {
        public IResult Add(ReservationStatu reservationStatu);
        public IResult Update(ReservationStatu reservationStatu);
        public IResult Delete(ReservationStatu reservationStatu);
        public IDataResult<List<ReservationStatu>> GetAll();
        public IDataResult<ReservationStatu> Get(int id);
    }
}