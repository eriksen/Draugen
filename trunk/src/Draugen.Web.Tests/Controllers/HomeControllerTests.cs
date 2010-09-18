using Draugen.Model.Home;
using Draugen.ModelFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController _controller;

        [TestInitialize]
        public void InitializeTest()
        {
            var modelFactory = new Mock<IModelFactory<IndexModel>>();
            _controller = new HomeController(modelFactory.Object);
        }

        [TestMethod]
        public void Index_MustReturnViewWithIndexData()
        {
        }

    }
}
