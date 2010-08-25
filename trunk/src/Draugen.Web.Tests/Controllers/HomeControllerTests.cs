using System.Reflection;
using System.Web.Mvc;
using Draugen.Services;
using Draugen.Services.ViewData.Home;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private Mock<IViewDataService> _serviceMock;
        private HomeController _controller;

        [TestInitialize]
        public void InitializeTest()
        {
            _serviceMock = new Mock<IViewDataService>();
            _controller = new HomeController(_serviceMock.Object);
        }

        [TestMethod]
        public void Index_MustReturnViewWithIndexData()
        {
            var model = new IndexData();
            _serviceMock.Setup(s => s.GetHomePageData()).Returns(model);
            var result = (ViewResult)_controller.Index();
            Assert.AreSame(model, result.ViewData.Model);
        }

    }
}
