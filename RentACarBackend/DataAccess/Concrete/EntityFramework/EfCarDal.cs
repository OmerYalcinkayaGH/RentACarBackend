using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result=from car in context.Cars
                       join fuelType in context.FuelTypes on car.FuelTypeId equals fuelType.FuelTypeId
                       join transmissonType in context.TransmissionTypes on car.TransmissionTypeId equals transmissonType.TransmissionTypeId
                       join carStatus in context.CarStatuses on car.StatusId equals carStatus.CarStatusId
                       join branch in context.Branches on car.BranchId equals branch.BranchId
                       select new CarDetailDto
                       {
                           CarId = car.CarId,
                           LicensePlate = car.LicensePlate,
                           Make = car.Make,
                           Model = car.Model,
                           Year = car.Year,
                           DailyPrice = car.DailyPrice,
                           FuelTypeName = fuelType.FuelTypeName,
                           TransmissionTypeName = transmissonType.TransmissionTypeName,
                           Mileage = car.Mileage,
                            StatusName = carStatus.Status,
                           BranchName = branch.Name
                       };

                return result.ToList();
            }
        }
    }
}
