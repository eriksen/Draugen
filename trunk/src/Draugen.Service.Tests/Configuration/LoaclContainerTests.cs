using System.Collections.Generic;
using Draugen.Data;
using Draugen.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using Microsoft.Practices.Unity;

namespace Draugen.Services.Configuration
{
    [TestClass]
    public class LoaclContainerTests
    {
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private LocalContainer _container;
        private Mock<ISession> _sessionMock;

        [TestInitialize]
        public void InitializeTest()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _sessionMock = new Mock<ISession>();
            var transactionMock = new Mock<ITransaction>();
            transactionMock.Setup(t => t.IsActive).Returns(true);
            _sessionMock.Setup(s => s.Transaction).Returns(transactionMock.Object);
            _unitOfWorkMock.Setup(s => s.Session).Returns(_sessionMock.Object);
            _container = new LocalContainer(_unitOfWorkMock.Object);
        }

        [TestMethod]
        public void Dispose_MustCallDisposeOnUnitOfWork()
        {
            _container.Dispose();
            _unitOfWorkMock.Verify(u => u.Dispose());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfSession()
        {
            Assert.AreSame(_sessionMock.Object, _container.Resolve<ISession>());
        }

        [TestMethod]
        public void Ctor_MustRegisterAllTypes()
        {
            Assert.IsInstanceOfType(_container.Resolve<IRepository<Fangst>>(), typeof(Repository<Fangst>));

        }
    }
}
