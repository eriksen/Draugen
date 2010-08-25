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
        private Mock<IUnitOfWorkFactory> _unitOfWorkFactoryMock;
        private TestableServiceBase _service;

        [TestInitialize]
        public void InitializeTest()
        {
            _unitOfWorkFactoryMock = new Mock<IUnitOfWorkFactory>();
            _container = new UnityContainer();
            _container.RegisterInstance(_unitOfWorkFactoryMock.Object);
            _service = new TestableServiceBase(_container);
        }

        [TestMethod]
        public void ServiceBase_MustResolveUnitOfWorkFactory()
        {
            Assert.AreSame(_container, _service.ContainerInstance);
            Assert.AreSame(_unitOfWorkFactoryMock.Object, _service.UnitOfWorkFactoryInstance);
        }

        private class TestableServiceBase : ServiceBase
        {
            public TestableServiceBase(IUnityContainer container) : base(container){}
            
            public IUnityContainer ContainerInstance
            {
                get { return Container; }
            }

            public IUnitOfWorkFactory UnitOfWorkFactoryInstance
            {
                get { return UnitOfWorkFactory; }
            }
        }
    }

    
}
