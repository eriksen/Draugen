﻿using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.Assemblers
{
    [TestClass]
    public class FangstAssemblerTest
    {
        private CultureInfo _culture;
        private FangstAssembler _assembler;
        private Fangst _fangst;

        [TestInitialize]
        public void InitializeTest()
        {
            _culture = new CultureInfo("no");
            _assembler = new FangstAssembler();
            _fangst = new Fangst()
                          {
                              Art = new Art {Navn = "navn"},
                              Dato = DateTime.Parse("2010-01-01"),
                              Fisker = new Fisker {Navn = "fiskernavn"},
                              Lengde = 2.1,
                              Poeng = 4.74523445,
                              Sted = new Sted {Navn = "stedsnavn"},
                              Vekt = 4.35
                          };
        }

        [TestMethod]
        public void WriteDto_MustSetArtToArtNavn()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("navn", result.Art);
        }

        [TestMethod]
        public void WriteDto_MustSetDatoToFormattedString()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("01.01.2010", result.Dato);
        }

        [TestMethod]
        public void WriteDto_MustSetFiskerToFiskerNavn()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("fiskernavn", result.Fisker);
        }

        [TestMethod]
        public void WriteDto_MustSetFormattedLengde()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("2,1", result.Lengde);
        }

        [TestMethod]
        public void WriteDto_MustSetPoengWithZeroDecimals()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("4", result.Poeng);
        }

        [TestMethod]
        public void WriteDto_MustStedNavn()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("stedsnavn", result.Sted);
        }

        [TestMethod]
        public void WriteDto_MustSetVekt()
        {
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("4,350", result.Vekt)  ;
        }

        [TestMethod]
        public void WriteDto_MustSetVekt_AlsoWhenVektIsAbove10()
        {
            _fangst.Vekt = 11.350;
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("11,350", result.Vekt);
        }

        [TestMethod]
        public void WriteDto_MustSetVekt_AlsoWhenVektIsSmall()
        {
            _fangst.Vekt = 0.006;
            var result = _assembler.WriteDto(_fangst, _culture);
            Assert.AreEqual("0,006", result.Vekt);
        }
    }
}
