using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMaintenanceRecordService
    {
        public IResult Add(MaintenanceRecord maintenanceRecord);
        public IDataResult<List<MaintenanceRecord>> GetAll();
        public IDataResult<MaintenanceRecord> GetById(int id);
        public IResult Update(MaintenanceRecord maintanenceRecord);
        public IResult Delete(MaintenanceRecord maintanenceRecord);
    }
}