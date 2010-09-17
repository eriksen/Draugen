using System.Collections.Generic;
using Draugen.Helpers;
using Draugen.Services.Builders;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services
{
    [TestClass]
    public class FangstServiceTests
    {
        private FangstService _service;
        private Mock<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>> _getFangsterResponseBuilder;
        private TestablePerCallContainer _perCallContainer;
        private Mock<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>> _builder;
        private GetFangsterRequest _request;
        private GetFangsterResponse _response;

        [TestInitialize]
        public void InitializeTests()
        {
            var globalContainer = new UnityContainer();
            var serviceContainer = new UnityContainer();
            _perCallContainer = new TestablePerCallContainer();

            _builder = new Mock<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>>();
            var sessionFactory = MyMocks.SessionFactory();

            _request = new GetFangsterRequest { Body = new GetFangsterRequestBody(), Header = new ServiceHeader() { Culture = "no" } };
            _response = new GetFangsterResponse { Body = new GetFangsterResponseBody() { FangstList = new FangstListDto(new List<FangstDto>()) } };

            globalContainer.RegisterInstance(sessionFactory.Object);
            globalContainer.RegisterInstance<IUnityContainer>("Service", serviceContainer);
            serviceContainer.RegisterInstance<IUnityContainer>(_perCallContainer);
            _perCallContainer.RegisterInstance(_builder.Object);
            _builder.Setup(b => b.Build(_request)).Returns(_response);

            _service = new FangstService(globalContainer);
        }

        [TestMethod]
        public void GetFangster_MustCallBuildOnPerCallResolvedBuilder()
        {
            var result = _service.GetFangster(_request);
            Assert.AreSame(_response, result);
        }

        [TestMethod]
        public void GetFangster_MustDisposePerCallContainer()
        {
            _service.GetFangster(_request);
            Assert.IsTrue(_perCallContainer.Disposed);
        }

        private class TestablePerCallContainer : UnityContainer
        {
            public bool Disposed;
            protected override void Dispose(bool disposing)
            {
                Disposed = true;
                base.Dispose(disposing);
            }
        }
    }
}
