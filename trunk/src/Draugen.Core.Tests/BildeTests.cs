using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class BildeTests
    {
        [TestMethod]
        public void Name_MustReturn_draugLegacyId()
        {
            var fangst = new Fangst() {LegacyId = 2};
            var bilde = new Bilde(fangst);
            Assert.AreEqual("draug2.jpg", bilde.Navn);
        }
    }
}
