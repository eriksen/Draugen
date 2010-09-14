using Draugen.Helpers;
using Draugen.Services.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            _container.RegisterInstance(MyMocks.SessionFactory().Object);
            _container.RegisterType<IUnityContainer, ServiceContainer>("Service");
            _service = new TestableServiceBase(_container);
        }

        [TestMethod]
        public void ServiceBase_MustResolveServiceContrainer()
        {
            Assert.IsInstanceOfType(_service.ContainerInstance, typeof(ServiceContainer));
        }

        private class TestableServiceBase : ServiceBase
        {
            public TestableServiceBase(IUnityContainer container) : base(container){}
            
            public IUnityContainer ContainerInstance
            {
                get { return Container; }
            }
        }

    }
}
