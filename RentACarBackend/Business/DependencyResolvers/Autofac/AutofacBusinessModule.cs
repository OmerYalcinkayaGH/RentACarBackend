using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Module = Autofac.Module;
namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BranchManager>().As<IBranchService>().SingleInstance();
            builder.RegisterType<EfBranchDal >().As<IBranchDal>().SingleInstance();

            builder.RegisterType<CarManager >().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal >().As<ICarStutusDal>().SingleInstance();

            builder.RegisterType<CarStatusManager >().As<ICarStatusService>().SingleInstance();
            builder.RegisterType<EfCarStatusDal >().As<ICarStutusDal>().SingleInstance();

            builder.RegisterType<CustomerManager >().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<FuelTypeManager>().As<IFuelTypeService>().SingleInstance();
            builder.RegisterType<EfFuelTypeDal>().As<IFuelTypeDal>().SingleInstance();

            builder .RegisterType <MaintenanceRecordManager>().As<IMaintenanceRecordService >().SingleInstance();
            builder.RegisterType<EfMaintenanceRecordDal>().As<IMaintenanceRecordDal>().SingleInstance();

            builder.RegisterType<PaymentManager >().As<IPaymentDal >().SingleInstance();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>().SingleInstance();

            builder.RegisterType<PaymentMethodManager>().As<IPaymentMethodService>().SingleInstance();
            builder.RegisterType<EfPaymentMethodDal>().As<IPaymentMethodDal >().SingleInstance();

            builder.RegisterType<RentalRecordManager >().As<IRentalRecordService>().SingleInstance();
            builder.RegisterType<EfRentalRecordDal>().As<IRentalRecordDal>().SingleInstance();

            builder.RegisterType<ReservationManager >().As<IReservationService>().SingleInstance();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>().SingleInstance();


            builder.RegisterType<ReservationStatusManager >().As<IReservationStatusService>().SingleInstance();
            builder.RegisterType<EfReservationStatusDal>().As<IReservationStatusDal>().SingleInstance();

            builder.RegisterType<TransmissionTypeManager>().As<ITransmissionTypeService>().SingleInstance();
            builder.RegisterType<EfTransmissionTypeDal>().As<ITransmissionTypeDal>().SingleInstance();
        }
    }
}
