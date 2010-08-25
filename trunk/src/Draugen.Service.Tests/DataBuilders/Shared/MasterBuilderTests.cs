using Draugen.Services.ViewData.Home;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.DataBuilders.Shared
{
    [TestClass]
    public class MasterBuilderTests
    {
        private MasterBuilder _builder;

        [TestInitialize]
        public void InitializeTest()
        {
            _builder = new MasterBuilder();
        }

        [TestMethod]
        public void Create_MustReturnNewT()
        {
            var result = _builder.Create<IndexData>();
            Assert.IsInstanceOfType(result, typeof(IndexData));
        }
    }
}
