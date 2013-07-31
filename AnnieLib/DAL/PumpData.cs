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
   public class PumpData:IRepository<Pump> ,IDisposable
   {

       private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public PumpData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<Pump> All
        {
            get 
            {
                try
                {
                    return this.m_AnnieDataContext.Pumps;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(Pump _T)
        {
            try
            {
                this.m_AnnieDataContext.Pumps.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public Pump GetById(string Id)
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

        public IQueryable<Pump> Search(System.Linq.Expressions.Expression<Func<Pump, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.Pumps.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(Pump _T)
        {

            try
            {
                m_AnnieDataContext.Pumps.Add(_T);
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
