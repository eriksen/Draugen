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
            Assert.AreSame(_container, _service.ContainerInstance);
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
