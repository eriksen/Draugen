using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class KommentarTest
    {
        private Kommentar _kommentar;

        [TestInitialize]
        public void InitializeTest()
        {
            _kommentar = new Kommentar();
        }

        [TestMethod]
        public void SetKommentar_MustSetTheKommentar()
        {
            _kommentar.Innhold = "noe innhold";
            Assert.AreEqual("noe innhold", _kommentar.Innhold);
        }

        [TestMethod]
        public void SetKommmentar_MustSet3Periods_WhenValueIsNullOrWhiteSpace()
        {
            _kommentar.Innhold = null;
            Assert.AreEqual("...", _kommentar.Innhold);

            _kommentar.Innhold = "";
            Assert.AreEqual("...", _kommentar.Innhold);

            _kommentar.Innhold = " ";
            Assert.AreEqual("...", _kommentar.Innhold);
        }
    }
}
