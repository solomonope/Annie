﻿using BitworkSystem.Annie.BO;
using BitworkSystem.Annie.DAL.Contract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitworkSystem.Annie.DAL
{
    public class StationData :IRepository<Station>,IDisposable
    {
        private AnnieDataContext m_AnnieDataContext;
        private Logger m_Logger;
        public StationData()
        {
            m_AnnieDataContext = new AnnieDataContext();
            m_Logger = LogManager.GetCurrentClassLogger();
        }
        public IQueryable<Station> All
        {
            get 
            {
                try
                {
                    return m_AnnieDataContext.Stations;
                }
                catch (Exception Ew)
                {
                    m_Logger.TraceException(Ew.Message, Ew);
                    return null;
                }
            }
        }

        public bool Save(Station _T)
        {
            try
            {
                m_AnnieDataContext.Stations.Add(_T);
                m_AnnieDataContext.SaveChanges();
                return true;
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return false;

            }
        }

        public Station GetById(string Id)
        {
            try
            {
                return Search(x => x.StationId.ToString() == Id).SingleOrDefault();
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public IQueryable<Station> Search(System.Linq.Expressions.Expression<Func<Station, bool>> predicate)
        {
            try
            {
                return m_AnnieDataContext.Stations.Where(predicate);
            }
            catch (Exception Ew)
            {
                m_Logger.TraceException(Ew.Message, Ew);
                return null;
            }
        }

        public bool Delete(Station _T)
        {
            try
            {
                m_AnnieDataContext.Stations.Remove(_T);
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
