using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        public IResult Add(Reservation reservation);
        public IResult Delete(Reservation reservation);
        public IResult Update(Reservation reservation);
        public IDataResult<List<Reservation>> GetAll();
        public IDataResult<Reservation> GetByID(int id);
    }
}
