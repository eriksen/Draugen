using Draugen.Helpers;
using Draugen.Services.Builders;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Services
{
    [TestClass]
    public class FangstServiceTests
    {
        private FangstService _service;
        private Mock<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>> _getFangsterResponseBuilder;
        private TestablePerCallContainer _perCallContainer;

        [TestInitialize]
        public void InitializeTests()
        {
            _getFangsterResponseBuilder = new Mock<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>>();

            _perCallContainer = new TestablePerCallContainer();
            _perCallContainer.RegisterInstance(_getFangsterResponseBuilder.Object);
            
            var serviceContainer = new UnityContainer();
            serviceContainer.RegisterInstance<IUnityContainer>(_perCallContainer);
            
            var sessionFactory = MyMocks.SessionFactory();
            var globalContainer = new UnityContainer();
            globalContainer.RegisterInstance(sessionFactory.Object);
            globalContainer.RegisterInstance<IUnityContainer>("Service", serviceContainer);
            
            _service = new FangstService(globalContainer);
        }

        [TestMethod]
        public void GetFangster_MustCallBuildOnPerCallResolvedBuilder()
        {
            var request = new GetFangsterRequest();
            _service.GetFangster(request);
            _getFangsterResponseBuilder.Verify(g => g.Build(request));
        }

        [TestMethod]
        public void GetFangster_MustDisposePerCallContainer()
        {
            _service.GetFangster(new GetFangsterRequest());
            Assert.IsTrue(_perCallContainer.Disposed);
        }

        private class TestablePerCallContainer : UnityContainer
        {
            public bool Disposed = false;
            protected override void Dispose(bool disposing)
            {
                Disposed = true;
                base.Dispose(disposing);
            }
        }
    }
}
