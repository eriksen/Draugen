using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.Assemblers.Cards
{
    [TestClass]
    public class FangstAssemblerTests
    {
        private FangstAssembler _fangstAssembler;
        private Fangst _domain;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangstAssembler = new FangstAssembler();
            _domain = new Fangst()
                          {
                              Art = new Art() { Navn = "artsnavn" },
                              Dato = DateTime.Parse("01-01-1975"),
                              Fisker = new Fisker() { Navn = "fiskernavn", Team = new Team(){Navn = "draugen"}},
                              LegacyId = 2,
                              Lengde = 3,
                              Sted = new Sted() { Navn = "stedsnavn" },
                              Vekt = 2.7,
                          };
        }

        [TestMethod]
        public void Create_MustCreateFangstCard()
        {
            var result = _fangstAssembler.Create(_domain);
            Assert.AreEqual("artsnavn", result.Art);
            Assert.AreEqual("01.01.1975", result.Dato);
            Assert.AreEqual("fiskernavn", result.Fisker);
            Assert.AreEqual("3", result.Lengde);
            Assert.AreEqual("stedsnavn", result.Sted);
            Assert.AreEqual("2,7", result.Vekt);
            Assert.AreEqual("draugen", result.Team);
        }

        [TestMethod]
        public void Create_MustCreateBilde()
        {
            var result = _fangstAssembler.Create(_domain).Bilde;
            Assert.AreEqual("artsnavn", result.Alt);
            Assert.AreEqual("draug2.jpg", result.Navn);
        }
    }
}
