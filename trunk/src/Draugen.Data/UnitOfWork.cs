﻿using System;
using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session != null);
        }

        public UnitOfWork(IUnitOfWorkFactory unitOfWorkFactory, ISessionFactory sessionFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Session = sessionFactory.OpenSession();
            Session.BeginTransaction();
        }

        public ISession Session { get; private set; }

        public void Dispose()
        {
            Session.Transaction.Commit();
            Session.Dispose();
            _unitOfWorkFactory.Destroy();
            //try
            //{
            //    Session.Transaction.Commit();
            //}
            //catch (Exception)
            //{
            //    Session.Transaction.Rollback();
            //}
            //finally
            //{
            //    Session.Dispose();
            //}
        }
    }
}
