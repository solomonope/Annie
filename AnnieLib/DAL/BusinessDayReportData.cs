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
    public class BusinessDayReportData:IRepository<BusinessDayReport>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;

        public BusinessDayReportData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<BusinessDayReport> All
        {
            
           get
            {
                try
                {
                    return this.m_AnnieDataContext.BusinessDayReports;
                }
                catch (Exception Ew)
                {
                   
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
           
            }
        }

        public bool Save(BusinessDayReport _T)
        {
            try
            {
                m_AnnieDataContext.BusinessDayReports.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public BusinessDayReport GetById(string Id)
        {
            try
            {
                return this.Search(x => x.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null; 
            }
        }

        public IQueryable<BusinessDayReport> Search(System.Linq.Expressions.Expression<Func<BusinessDayReport, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.BusinessDayReports.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null; 
            }
        }

        public bool Delete(BusinessDayReport _T)
        {
            try
            {
                this.m_AnnieDataContext.BusinessDayReports.Remove(_T);
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
