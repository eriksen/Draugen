using Draugen.Data;
using Draugen.Services.DataBuilders;
using Draugen.Services.ViewData.Home;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services
{
    [TestClass]
    public class ViewDataServiceTests
    {
        private UnityContainer _container;
        private ViewDataService _service;

        [TestInitialize]
        public void InitializeTest()
        {
            var unitOfWorkFactoryMock = new Mock<IUnitOfWorkFactory>();
            _container = new UnityContainer();
            _container.RegisterInstance(unitOfWorkFactoryMock.Object);
            _service = new ViewDataService(_container);
        }

        [TestMethod]
        public void GetHomePageData_MustReutrnObjectFromBuilder()
        {
            var data = new IndexData();
            var builderMock = new Mock<IBuilder<IndexData>>();
            builderMock.Setup(b => b.Build()).Returns(data);
            _container.RegisterInstance(builderMock.Object);

            var result = _service.GetHomePageData();
            Assert.AreSame(data, result);
        }
    }
}
