using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class FangstTests
    {
        private Fangst _fangst;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangst = new Fangst()
                          {
                              Fisker = new Fisker()
                          };
        }

        [TestMethod]
        public void Ctor_MustInitializeBildeProperty()
        {
            Assert.IsNotNull(_fangst.Bilde);
        }

        [TestMethod]
        public void Kommentar_MustReturnFirstKommentarByDateByFisker()
        {
            var kommentar1 = new Kommentar {Forfatter = _fangst.Fisker, Opprettet = DateTime.Parse("2000.01.22")};
            var kommentar2 = new Kommentar { Forfatter = _fangst.Fisker, Opprettet = DateTime.Parse("2000.01.10") };
            var kommentar3 = new Kommentar { Forfatter = new Fisker(), Opprettet = DateTime.Parse("2000.01.01") };
            _fangst.Kommentarer.Add(kommentar1);
            _fangst.Kommentarer.Add(kommentar2);
            _fangst.Kommentarer.Add(kommentar3);
            Assert.AreSame(kommentar2, _fangst.Kommentar);
        }

        [TestMethod]
        public void Kommentar_MustReturn3Periods_WhenNoKommentarByFiskerExists()
        {
            _fangst.Kommentarer.Add(new Kommentar() { Forfatter = new Fisker(), Opprettet = DateTime.Parse("2000.01.22")});
            Assert.AreEqual("...", _fangst.Kommentar.Innhold);
            Assert.AreSame(_fangst.Fisker, _fangst.Kommentar.Forfatter);
            Assert.AreEqual(_fangst.Dato, _fangst.Kommentar.Opprettet);
        }
    }
}
