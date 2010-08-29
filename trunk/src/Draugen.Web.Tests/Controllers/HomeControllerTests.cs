using System.Web.Mvc;
using Draugen.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private Mock<IFangstService> _serviceMock;
        private HomeController _controller;

        [TestInitialize]
        public void InitializeTest()
        {
            _serviceMock = new Mock<IFangstService>();
            _controller = new HomeController(_serviceMock.Object);
        }

        [TestMethod]
        public void Index_MustReturnViewWithIndexData()
        {
        }

    }
}
