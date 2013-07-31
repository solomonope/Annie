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
    public class BusinessDayData: IRepository<BusinessDay>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public BusinessDayData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<BusinessDay> All
        {
            get
            {
                try
                {
                    return this.m_AnnieDataContext.BusinessDays;
                }
                catch (Exception Ew)
                {
                   
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(BusinessDay _T)
        {
            try
            {
                this.m_AnnieDataContext.BusinessDays.Add(_T);
                this.m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public BusinessDay GetById(string Id)
        {
            try
            {
                return Search(x => x.BusinessDayId.ToString() == Id).SingleOrDefault<BusinessDay>();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<BusinessDay> Search(System.Linq.Expressions.Expression<Func<BusinessDay, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.BusinessDays.Where(predicate);
            }
            catch(Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(BusinessDay _T)
        {
            try
            {
                this.m_AnnieDataContext.BusinessDays.Remove(_T);
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
