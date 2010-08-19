using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Draugen.Web.Setup;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Web.Tests.Setup
{
    [TestClass]
    public class DraugenUnityContainerTests
    {
        private DraugenUnityContainer _container;
        private Mock<ISessionFactory> _sessionFactory;

        [TestInitialize]
        public void Initialize()
        {
            _sessionFactory = new Mock<ISessionFactory>();
            _sessionFactory.Setup(s => s.OpenSession()).Returns(new Mock<ISession>().Object);
            _container = new DraugenUnityContainer(_sessionFactory.Object);
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfItself()
        {
            Assert.AreSame(_container, _container.Resolve<IUnityContainer>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfISessionFactory()
        {
            Assert.AreSame(_sessionFactory.Object, _container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInterfaces()
        {
            Assert.IsInstanceOfType(_container.Resolve<IUnitOfWork>(), typeof(UnitOfWork));
            Assert.IsInstanceOfType(_container.Resolve<IUnitOfWorkFactory>(), typeof(UnitOfWorkFactory));
            Assert.IsInstanceOfType(_container.Resolve<IRepository<Fangst>>(), typeof(Repository<Fangst>));
            Assert.IsInstanceOfType(_container.Resolve<IPageDataService>(), typeof(PageDataService));
        }
    }
}
