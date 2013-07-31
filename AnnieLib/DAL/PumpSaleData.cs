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
    public class PumpSaleData :IRepository<PumpSale>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public PumpSaleData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<PumpSale> All
        {
            get
            {
                try
                {
                    return m_AnnieDataContext.PumpSales;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(PumpSale _T)
        {
            try
            {
                m_AnnieDataContext.PumpSales.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public PumpSale GetById(string Id)
        {
            try
            {
                return this.Search(x => x.PumpSaleId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<PumpSale> Search(System.Linq.Expressions.Expression<Func<PumpSale, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.PumpSales.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(PumpSale _T)
        {
            try
            {
                m_AnnieDataContext.PumpSales.Add(_T);
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
