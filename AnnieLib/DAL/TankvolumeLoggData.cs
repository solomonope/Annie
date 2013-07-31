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
    public class TankvolumeLoggData :IRepository<TankVolumeLogg>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public TankvolumeLoggData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<TankVolumeLogg> All
        {
            get 
            {
                try
                {
                    return m_AnnieDataContext.TankVolumeLoggs;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(TankVolumeLogg _T)
        {
            try
            {
                m_AnnieDataContext.TankVolumeLoggs.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public TankVolumeLogg GetById(string Id)
        {
            try
            {
                return this.Search(x => x.TankVolumeLoggId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<TankVolumeLogg> Search(System.Linq.Expressions.Expression<Func<TankVolumeLogg, bool>> predicate)
        {
            try
            {
                return m_AnnieDataContext.TankVolumeLoggs.Where(predicate);

            }
            catch (Exception Ew)
            {

                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(TankVolumeLogg _T)
        {
            try
            {
                m_AnnieDataContext.TankVolumeLoggs.Remove(_T);
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
