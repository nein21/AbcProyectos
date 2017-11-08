﻿using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcProyecto
{
    public class NHibernateManager : IDisposable
    {
        private static ISessionFactory _sessionFactory;
        public ISession Session;

        public NHibernateManager()
        {
            CreateSession();
            OpenSession();
        }

        private void CreateSession()
        {
            if (_sessionFactory == null)
            {
                var configuration = new Configuration().Configure("hibernate.cfg.xml");
                configuration.AddAssembly("AbcProyecto");
                _sessionFactory = configuration.BuildSessionFactory();
            }

            Session = OpenSession();
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        public static void CloseSession()
        {
            _sessionFactory.Dispose();
        }

        #region Miembros de IDisposable
        public void Dispose()
        {
            CloseSession();
        }
        #endregion
    }
}
