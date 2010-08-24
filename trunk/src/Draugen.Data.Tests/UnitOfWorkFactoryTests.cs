using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Data
{
    [TestClass]
    public class UnitOfWorkFactoryTests
    {
        private UnitOfWorkFactory _factory;
        private Mock<ISessionFactory> _sessionFactory;
        private Mock<ISession> _session;

        [TestInitialize]
        public void Initialize()
        {
            _session = new Mock<ISession>();
            _sessionFactory = new Mock<ISessionFactory>();
            _sessionFactory.Setup(s => s.OpenSession()).Returns(_session.Object);
            _factory = new UnitOfWorkFactory(_sessionFactory.Object);
        }

        [TestMethod]
        public void Create_MustReturnInstanceOfIUnitOfWork()
        {
            Assert.IsNotNull(_factory.Create());
        }

        [TestMethod]
        public void Create_MustPassSessionFactoryToCreatedUnitOfWork()
        {
            var result = _factory.Create();
            Assert.AreSame(_session.Object, result.Session);
        }

        [TestMethod]
        public void Dispose_MustDisposeSessionFactory()
        {
            _factory.Dispose();
            _sessionFactory.Verify(s => s.Dispose());
        }

        [TestMethod]
        public void Create_MustNotCreate_WhenUnitOfWorkInstanceIsAlreadyCreated()
        {
            var uof = _factory.Create();
            Assert.AreSame(uof, _factory.Create());
        }

        [TestMethod]
        public void DestoryCurrentUnitOfWork()
        {
            var uow = _factory.Create();
            _factory.DestroyCurrentUnitOfWork();
            Assert.AreNotSame(uow, _factory.Create());
        }
    }
}
