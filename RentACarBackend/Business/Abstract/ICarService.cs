using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
       public IResult Add(Car car);
        public IDataResult<List<Car>> GetAll();
        public IDataResult<Car> GetById(int id);
        public IResult Update(Car car);
        public IResult Delete(Car car);
        public IDataResult<List<CarDetailDto>> GetCarDetails();
        
    }
}
