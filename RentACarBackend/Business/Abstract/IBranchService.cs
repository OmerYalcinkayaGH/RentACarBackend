using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBranchService
    {
        public IResult Add(Branch branc);
        public IDataResult<List<Branch>> GetAll();
        public IDataResult<Branch> GetById(int id);
        public IResult Update(Branch branch);
        public IResult Delete(Branch branch);
    }
}
