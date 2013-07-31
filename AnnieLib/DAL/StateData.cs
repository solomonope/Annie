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
   public  class StateData :IRepository<State>,IDisposable
    {

        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public StateData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<State> All
        {
            get
            {
                try
                {
                    return m_AnnieDataContext.States;

                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(State _T)
        {
            try
            {
                m_AnnieDataContext.States.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;
            }
        }

        public State GetById(string Id)
        {
            try
            {
                return this.Search(x => x.StateId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<State> Search(System.Linq.Expressions.Expression<Func<State, bool>> predicate)
        {
            try
            {
                return this.m_AnnieDataContext.States.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(State _T)
        {
            try
            {
                m_AnnieDataContext.States.Remove(_T);
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
