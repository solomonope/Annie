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
    public class TankReadingData :IRepository<TankReading>,IDisposable
    {
         private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public TankReadingData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<TankReading> All
        {
            get
            {
                try
                {
                    return m_AnnieDataContext.TankReadings;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(TankReading _T)
        {
            try
            {
                m_AnnieDataContext.TankReadings.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return false;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;

            }
        }

        public TankReading GetById(string Id)
        {
            try
            {
               return  this.Search(X => X.TankReadingId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<TankReading> Search(System.Linq.Expressions.Expression<Func<TankReading, bool>> predicate)
        {
            try
            {
                return m_AnnieDataContext.TankReadings.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(TankReading _T)
        {
            try
            {
                m_AnnieDataContext.TankReadings.Remove(_T);
                m_AnnieDataContext.SaveChanges();
                return false;
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
