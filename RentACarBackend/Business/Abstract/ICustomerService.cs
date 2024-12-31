using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{    
        public interface ICustomerService
        {
            public IResult Add(Customer customer);
            public IDataResult<List<Customer>> GetAll();
            public IDataResult<Customer> GetById(int id);
            public IResult Update(Customer customer);
            public IResult Delete(Customer customer);
        }
    
}