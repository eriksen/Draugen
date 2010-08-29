using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{
    [TestClass]
    public class FilterTests
    {
        private IQueryable<Fangst> _fangster;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangster = new List<Fangst>
                            {
                                new Fangst {Art = new Art {Id = 2}, Vekt = 2},
                                new Fangst {Art = new Art {Id = 3}, Vekt = 3},
                                new Fangst {Art = new Art {Id = 4}, Vekt = 4},
                                new Fangst {Art = new Art {Id = 5}, Vekt = 5},
                                new Fangst {Art = new Art {Id = 6}, Vekt = 6}
                            }.AsQueryable();
        }

        [TestMethod]
        public void Refine_MustCorrectlyFilterProperty()
        {
            var filter = new Filter("Vekt", FilterOperator.Equals, 4);
            var result = filter.Refine(_fangster);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void Refine_MustCorrectlyFilterSubProperty()
        {
            var filter = new Filter("Art.Id", FilterOperator.Equals, 4);
            var result = filter.Refine(_fangster);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void Refine_MustCorrectlyFilterProperty_WithGreatherThan()
        {
            var filter = new Filter("Vekt", FilterOperator.GreaterThan, 4);
            var result = filter.Refine(_fangster);
            Assert.AreEqual(2, result.Count());
        }
        
        [TestMethod]
        public void Refine_MustCorrectlyFilterProperty_WithLessThan()
        {
            var filter = new Filter("Vekt", FilterOperator.LessThan, 5);
            var result = filter.Refine(_fangster);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Refine_MustThrowArgumentException_WhenPropertyDoesNotExist()
        {
            new Filter("Bogus", FilterOperator.Equals, 1).Refine(_fangster);
        }
    }
}
