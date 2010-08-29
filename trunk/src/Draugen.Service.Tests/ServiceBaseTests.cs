using System;
using System.Collections.Generic;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using Draugen.Data;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services
{
    [TestClass]
    public class ServiceBaseTests
    {
        private IUnityContainer _container;
        private TestableServiceBase _service;

        [TestInitialize]
        public void InitializeTest()
        {
            _container = new UnityContainer();
            _service = new TestableServiceBase(_container);
        }

        [TestMethod]
        public void ServiceBase_MustResolveUnitOfWorkFactory()
        {
            Assert.AreSame(_container, _service.GlobalContainerInstance);
        }

        private class TestableServiceBase : ServiceBase
        {
            public TestableServiceBase(IUnityContainer container) : base(container){}
            
            public IUnityContainer GlobalContainerInstance
            {
                get { return GlobalContainer; }
            }
        }

    }

    public static class Extensions
    {
    }
    
}
