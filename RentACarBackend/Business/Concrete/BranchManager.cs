using Business.Abstract;
using Business.Constants.Messages;
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

    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;
        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        [ValidationAspect(typeof(BranchValidation))]
        public IResult Add(Branch branc)
        {
            _branchDal.Add(branc);
            return new SuccessResult(BranchMessages.AddedSuccess);
        }

        public IResult Delete(Branch branch)
        {
            _branchDal.Delete(branch);
            return new SuccessResult(BranchMessages.DeletedSuccess);
        }

        public IDataResult<List<Branch>> GetAll()
        {
            return new SuccessDataResult<List<Branch>>(BranchMessages.ListedSuccess, _branchDal.GetAll());
        }

        public IDataResult<Branch> GetById(int id)
        {
            return new SuccessDataResult<Branch>(BranchMessages.GetByIdSuccess, _branchDal.Get(p => p.BranchId == id));
        }

        [ValidationAspect(typeof(BranchValidation))]
        public IResult Update(Branch branch)
        {
            _branchDal.Update(branch);
            return new SuccessResult(BranchMessages.UpdatedSuccess);
        }
    }
}
