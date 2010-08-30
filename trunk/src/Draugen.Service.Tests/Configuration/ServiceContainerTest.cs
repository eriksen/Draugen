using Draugen.Data;
using Draugen.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using Microsoft.Practices.Unity;

namespace Draugen.Services.Configuration
{
    [TestClass]
    public class ServiceContainerTest
    {
        private Mock<ISessionFactory> _sessionFactory;
        private ServiceContainer _container;

        [TestInitialize]
        public void InitializeTest()
        {
            _sessionFactory = MyMocks.SessionFactory();
            _container = new ServiceContainer(_sessionFactory.Object);
        }

        [TestMethod]
        public void Ctor_MustRegistgerInstanceOfSessionFactory()
        {
            Assert.AreSame(_sessionFactory.Object, _container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void Ctor_MustRegisterTypes()
        {
            Assert.IsInstanceOfType(_container.Resolve<IUnityContainer>(), typeof(PerCallContainer));
            Assert.IsInstanceOfType(_container.Resolve<IUnitOfWork>(), typeof(UnitOfWork));
        }
    }
}
