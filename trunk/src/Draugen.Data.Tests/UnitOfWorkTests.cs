using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Data.Tests
{
    [TestClass]
    public class UnitOfWorkTests
    {
        private Mock<ISession> _session;
        private Mock<ISessionFactory> _sessionFactory;
        private UnitOfWork _unitOfWork;
        private Mock<ITransaction> _transaction;

        [TestInitialize]
        public void InitializeTest()
        {
            var unitOfWorkFactory = new Mock<IUnitOfWorkFactory>();
            _transaction = new Mock<ITransaction>();
            _session = new Mock<ISession>();
            _session.Setup(s => s.Transaction).Returns(_transaction.Object);
            _sessionFactory = new Mock<ISessionFactory>();
            _sessionFactory.Setup(s => s.OpenSession()).Returns(_session.Object);
            _unitOfWork = new UnitOfWork(unitOfWorkFactory.Object, _sessionFactory.Object);
        }

        [TestMethod]
        public void Session_MustReturnSessionProvidedBySessionFactory()
        {
            Assert.AreEqual(_session.Object, _unitOfWork.Session);
        }

        [TestMethod]
        public void Ctor_MustCallBeginTransaction()
        {
            _session.Verify(s => s.BeginTransaction());
        }

        [TestMethod]
        public void Dispose_MustCommitTransaction()
        {
            _unitOfWork.Dispose();
            _transaction.Verify(t => t.Commit());
            _transaction.Verify(t => t.Rollback(), Times.Never());
        }

        [TestMethod]
        public void Session_MustBeDisposed_WhenSessionIsSuccessfullyComitted()
        {
            _unitOfWork.Dispose();
            _session.Verify(s => s.Dispose());
        }

        [TestMethod]
        public void Dispose_MustRollbackTransaction_WhenCommitFails()
        {
            _transaction.Setup(t => t.Commit()).Throws(new Exception());
            _unitOfWork.Dispose();
            _transaction.Verify(t => t.Rollback());
        }

        [TestMethod]
        public void Session_MustBeDisposed_WhenSessionIsRolledback()
        {
            _transaction.Setup(t => t.Commit()).Throws(new Exception());
            _unitOfWork.Dispose();
            _session.Verify(s => s.Dispose());
        }

    }
}
