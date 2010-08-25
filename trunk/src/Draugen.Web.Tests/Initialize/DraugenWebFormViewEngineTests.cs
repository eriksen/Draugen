using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Initialize
{
    [TestClass]
    public class DraugenWebFormViewEngineTests
    {
        private DraugenWebFormViewEngine _engine;

        [TestInitialize]
        public void InitializeTests()
        {
            _engine = new DraugenWebFormViewEngine();
        }

        [TestMethod]
        public void Ctor_MustRegisterPartialViewLocationFormats()
        {
            Assert.AreEqual("~/Views/Shared/{0}.ascx", _engine.PartialViewLocationFormats[0]);
            Assert.AreEqual("~/Views/Shared/Cards/{0}.ascx", _engine.PartialViewLocationFormats[1]);
            Assert.AreEqual("~/Views/Shared/Decks/{0}.ascx", _engine.PartialViewLocationFormats[2]);
        }
    }
}
