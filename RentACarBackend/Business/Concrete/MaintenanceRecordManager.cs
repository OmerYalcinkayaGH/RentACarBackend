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
    public class MaintenanceRecordManager : IMaintenanceRecordService
    {
        IMaintenanceRecordDal _maintenanceRecord;

        public MaintenanceRecordManager(IMaintenanceRecordDal maintenanceRecord)
        {
            _maintenanceRecord = maintenanceRecord;
        }

        public IResult Add(MaintenanceRecord maintenanceRecord)
        {
            _maintenanceRecord.Add(maintenanceRecord);
            return new SuccessResult(MaintenanceRecordMessages.AddedSuccess);
        }

        public IResult Delete(MaintenanceRecord maintanenceRecord)
        {
            _maintenanceRecord.Delete(maintanenceRecord);
            return new SuccessResult(MaintenanceRecordMessages.DeletedSuccess);
        }

        public IDataResult<List<MaintenanceRecord>> GetAll()
        {
            return new SuccessDataResult <List<MaintenanceRecord>>(MaintenanceRecordMessages .ListedSuccess,
                _maintenanceRecord .GetAll ());
        }

        public IDataResult<MaintenanceRecord> GetById(int id)
        {
            return new SuccessDataResult<MaintenanceRecord>(MaintenanceRecordMessages.GetByIdSuccess, 
              _maintenanceRecord.Get(p=>p.CardId ==id));
        }

        public IResult Update(MaintenanceRecord maintanenceRecord)
        {
            _maintenanceRecord.Update(maintanenceRecord);
            return new SuccessResult(MaintenanceRecordMessages .UpdatedSuccess);
        }
    }
}
