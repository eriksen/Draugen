using Draugen.Configuration;
using Draugen.Data;
using Draugen.Helpers;
using Draugen.Services;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Initialize
{
    [TestClass]
    public class GlobalContainerTests
    {
        private GlobalContainer _container;
        private Mock<ISessionFactory> _sessionFactory;

        [TestInitialize]
        public void Initialize()
        {
            _sessionFactory = MyMocks.SessionFactory();
            _container = new GlobalContainer(_sessionFactory.Object);
        }

        [TestMethod]
        public void CtorEmpty_MustRegisterInstanceOfISessionFactory()
        {
            Assert.AreSame(_sessionFactory.Object, _container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfItself()
        {
            Assert.AreSame(_container, _container.Resolve<IUnityContainer>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfISessionFactory()
        {
            var container = _container.Resolve<IUnityContainer>();
            Assert.AreSame(_sessionFactory.Object, container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInterfaces()
        {
            Assert.IsInstanceOfType(_container.Resolve<IUnitOfWork>(), typeof(UnitOfWork));
            Assert.IsInstanceOfType(_container.Resolve<IFangstService>(), typeof(FangstService));
            Assert.IsInstanceOfType(_container.Resolve<IUnityContainer>(), typeof(GlobalContainer));
        }

    }
}
