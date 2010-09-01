using System;
using System.Reflection;
using Draugen.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Data
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
            _transaction = MyMocks.Transaction();
            _session = MyMocks.Session(_transaction);
            _sessionFactory = MyMocks.SessionFactory(_session);
            _unitOfWork = new UnitOfWork(_sessionFactory.Object);
        }

        [TestMethod]
        public void Session_MustReturnSessionProvidedBySessionFactory()
        {
            Assert.AreEqual(_session.Object, _unitOfWork.Session);
        }

        [TestMethod]
        public void Session_MustBeDisposed_WhenSessionIsSuccessfullyComitted()
        {
            _unitOfWork.Dispose();
            _session.Verify(s => s.Dispose());
        }

        [TestMethod]
        public void BeginTransaction_MustCallBeginTransactionOnSession()
        {
            _unitOfWork.BeginTransaction();
            _session.Verify(s => s.BeginTransaction(), Times.Once());
        }

        [TestMethod]
        public void CommitTransaction_MustCallSessionCommitAndReturnTrue()
        {
            Assert.IsTrue(_unitOfWork.CommitTransaction());
            _transaction.Verify(t => t.Commit(), Times.Once());
        }

        [TestMethod]
        public void CommitTransaction_MusrRollbackAndReturnFalse_WhenCommitThrows()
        {
            _transaction.Setup(t => t.Commit()).Throws(new Exception());
            Assert.IsFalse(_unitOfWork.CommitTransaction());
            _transaction.Verify(t => t.Rollback(), Times.Once());
        }
    }
}
