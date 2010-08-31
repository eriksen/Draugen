using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class FangstTests
    {
        [TestMethod]
        public void Ctor_MustInitializeBildeProperty()
        {
            var fangst = new Fangst();
            Assert.IsNotNull(fangst.Bilde);
        }
    }
}
