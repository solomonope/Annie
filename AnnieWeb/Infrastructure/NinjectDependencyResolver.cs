using BitworkSystem.Annie.BLL;
using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using BitworkSystem.Annie.DAL;
using BitworkSystem.Annie.DAL.Contract;
using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
namespace AnnieWeb.Infrastructure
{

    public class NinjectDependencyResolver : System.Web.Mvc.IDependencyResolver, IDisposable
    {
        private IKernel ninjectKernel;

        public IBindingToSyntax<T> Bind<T>()
        {
            return ninjectKernel.Bind<T>();
        }

        public IKernel Kernel
        {
            get
            {
                return ninjectKernel;
            }
        }
        
        public NinjectDependencyResolver()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            return ninjectKernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ninjectKernel.GetAll(serviceType);
        }

      
        #endregion

        private void AddBindings()
        {
            ninjectKernel.Bind<IRepository<BusinessDay>>().To<BusinessDayData>();
            ninjectKernel.Bind<IRepository<BusinessDayReport>>().To<BusinessDayReportData>();
            ninjectKernel.Bind<IRepository<City>>().To<CityData>();
            ninjectKernel.Bind<IRepository<Country>>().To<CountryData>();
            ninjectKernel.Bind<IRepository<Fluid>>().To<FluidData>();
            ninjectKernel.Bind<IRepository<Pump>>().To<PumpData>();
            ninjectKernel.Bind<IRepository<PumpReading>>().To<PumpReadingData>();

            ninjectKernel.Bind<IRepository<PumpSale>>().To<PumpSaleData>();
            ninjectKernel.Bind<IRepository<SalesRate>>().To<SalesRateData>();
            ninjectKernel.Bind<IRepository<State>>().To<StateData>();
            ninjectKernel.Bind<IRepository<Station>>().To<StationData>();
            ninjectKernel.Bind <IRepository<TankActivity>>().To<TankActivityData>();
            ninjectKernel.Bind<IRepository<TankReading>>().To<TankReadingData>();
            ninjectKernel.Bind<IRepository<TankVolumeLogg>>().To<TankvolumeLoggData>();



            ninjectKernel.Bind<IManager<BusinessDay>>().To<BusinessDayManager>();
            ninjectKernel.Bind<IManager<BusinessDayReport>>().To<BusinessDayReportManager>();
            ninjectKernel.Bind<IManager<City>>().To<CityManager>();
            ninjectKernel.Bind<IManager<Country>>().To<CountryManager>();
            ninjectKernel.Bind<IManager<Fluid>>().To<FluidManager>();
            ninjectKernel.Bind<IManager<Pump>>().To<PumpManager>();
            ninjectKernel.Bind<IManager<PumpReading>>().To<PumpReadingManager>();

            ninjectKernel.Bind<IManager<PumpSale>>().To<PumpSaleManager>();
            ninjectKernel.Bind<IManager<SalesRate>>().To<SalesRateManager>();
            ninjectKernel.Bind<IManager<State>>().To<StateManager>();
            ninjectKernel.Bind<IManager<Station>>().To<StationManager>();
            ninjectKernel.Bind<IManager<TankActivity>>().To<TankActivityManager>();
            ninjectKernel.Bind<IManager<TankReading>>().To<TankReadingManager>();
            ninjectKernel.Bind<IManager<TankVolumeLogg>>().To<TankVolumeLoggManager>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ninjectKernel.Dispose();
            }
        }

        
    }
}