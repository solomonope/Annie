using BitworkSystem.Annie.BO;
using BitworkSystem.Annie.DAL.Contract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitworkSystem.Annie.DAL
{
    public class FluidData:IRepository<Fluid>,IDisposable
    {

        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public FluidData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<Fluid> All
        {
            get 
            {
                try
                {
                   return this.m_AnnieDataContext.Fluids;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(Fluid _T)
        {
            try
            {
                this.m_AnnieDataContext.Fluids.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public Fluid GetById(string Id)
        {
            try
            {
                return this.Search(x => x.FluidId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<Fluid> Search(System.Linq.Expressions.Expression<Func<Fluid, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.Fluids.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(Fluid _T)
        {
            try
            {
                this.m_AnnieDataContext.Fluids.Remove(_T);
                this.m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this.m_AnnieDataContext.Dispose();
        }
    }
}
