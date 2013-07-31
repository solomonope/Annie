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
   public  class TankActivityData :IRepository<TankActivity>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public TankActivityData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<TankActivity> All
        {
            get 
            {
                try
                {
                    return m_AnnieDataContext.TankActivities;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(TankActivity _T)
        {
            try
            {
                m_AnnieDataContext.TankActivities.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public TankActivity GetById(string Id)
        {
            try
            {
                return Search(x => x.TankActivityId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<TankActivity> Search(System.Linq.Expressions.Expression<Func<TankActivity, bool>> predicate)
        {
            try
            {
                return m_AnnieDataContext.TankActivities.Where(predicate);
                
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(TankActivity _T)
        {
            try
            
            {
                m_AnnieDataContext.TankActivities.Add(_T);
                m_AnnieDataContext.SaveChanges();
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
