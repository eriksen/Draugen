using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class FangstTests
    {
        [TestMethod]
        public void Vekt_MustReturnPercentageOfArtRekord()
        {
            var fangst = new Fangst() { Vekt = 25.0, Art = new Art() { Rekord = 100.0 } };
            Assert.AreEqual(25, fangst.Poeng());
        }

        [TestMethod]
        public void Ctor_MustInitializeBildeProperty()
        {
            var fangst = new Fangst();
            Assert.IsNotNull(fangst.Bilde);
        }
    }
}
