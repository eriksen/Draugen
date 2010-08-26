using System.Collections.Generic;
using Draugen.Configuration;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Draugen.Services.Assemblers;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.Assemblers.Decks;
using Draugen.Services.DataBuilders;
using Draugen.Services.DataBuilders.Home;
using Draugen.Services.DataBuilders.Shared;
using Draugen.Services.ViewData.Home;
using Draugen.Services.ViewData.Shared.Cards;
using Draugen.Services.ViewData.Shared.Decks;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Initialize
{
    [TestClass]
    public class DraugenContainerTests
    {
        private DraugenContainer _container;
        private Mock<ISessionFactory> _sessionFactory;

        [TestInitialize]
        public void Initialize()
        {
            _sessionFactory = new Mock<ISessionFactory>();
            _sessionFactory.Setup(s => s.OpenSession()).Returns(new Mock<ISession>().Object);
            _container = new DraugenContainer(_sessionFactory.Object);
        }

        [TestMethod]
        public void CtorEmpty_MustRegisterInstanceOfISessionFactory()
        {
            Assert.AreSame(_sessionFactory.Object, _container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfItself()
        {
            Assert.AreNotSame(_container, _container.Resolve<IUnityContainer>());
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
            Assert.IsInstanceOfType(_container.Resolve<IViewDataService>(), typeof(ViewDataService));
            Assert.IsInstanceOfType(_container.Resolve<IUnityContainer>(), typeof(DraugenContainer));

            Assert.IsInstanceOfType(_container.Resolve<IUnitOfWork>(), typeof(UnitOfWork));
        }

    }
}
