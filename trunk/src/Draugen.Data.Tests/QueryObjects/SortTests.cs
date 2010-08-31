using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{

    [TestClass]
    public class SortTests
    {
        private IQueryable<Art> _queryable;

        [TestInitialize]
        public void InitializeTest()
        {
            _queryable = new List<Art>
                                {
                                    new Art() {Navn = "B"},
                                    new Art() {Navn = "D"},
                                    new Art() {Navn = "A"},
                                    new Art() {Navn = "E"},
                                    new Art() {Navn = "C"}
                                }.AsQueryable();
        }

        [TestMethod]
        public void Refine_MustOrderAscending()
        {
            var result = new Sort("Navn", SortDirection.Ascending).Refine(_queryable);
            Assert.AreEqual("ABCDE" ,string.Join("", result.Select(r => r.Navn)));
        }

        [TestMethod]
        public void Refine_MustOrderDescending()
        {
            var result = new Sort("Navn", SortDirection.Descending).Refine(_queryable);
            Assert.AreEqual("EDCBA", string.Join("", result.Select(r => r.Navn)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Refine_MustThrowArgumentException_WhenPropertyDoesNotExist()
        {
            new Sort("Bogus", SortDirection.Descending).Refine(_queryable);
        }
    }
}
