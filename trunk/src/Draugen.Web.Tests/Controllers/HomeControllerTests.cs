using Draugen.Model.Hjem;
using Draugen.ModelFactories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private HjemController _controller;

        [TestInitialize]
        public void InitializeTest()
        {
            var modelFactory = new Mock<IFangsterFactory<HjemModel>>();
            _controller = new HjemController(modelFactory.Object);
        }

        [TestMethod]
        public void Index_MustReturnViewWithIndexData()
        {
        }

    }
}
