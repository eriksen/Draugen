using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{
    [TestClass]
    public class PageTests
    {
        private IQueryable<Art> _queryable;

        [TestInitialize]
        public void InitializeTest()
        {
            _queryable = new List<Art>
                             {
                                 new Art { Id = 1 },
                                 new Art { Id = 2 },
                                 new Art { Id = 3 },
                                 new Art { Id = 4 },
                                 new Art { Id = 5 },
                                 new Art { Id = 6 },
                                 new Art { Id = 7 },
                                 new Art { Id = 8 },
                                 new Art { Id = 9 },
                                 new Art { Id = 10 },
                             }.AsQueryable();
        }

        [TestMethod]
        public void PageMustCorrectlyBuildFirstPage()
        {
            var page = new PageQuery<Art>(1, 1);
            var result = page.Query(_queryable);
            Assert.AreEqual(1, result.Where(a => a.Id == 1).Count());
            Assert.AreEqual(0, result.Where(a => a.Id == 9).Count());
        }

        [TestMethod]
        public void PageMustCorrectlyBuildFifthPage()
        {
            var page = new PageQuery<Art>(5, 1);
            var result = page.Query(_queryable);
            Assert.AreEqual(1, result.Where(a => a.Id == 5).Count());
            Assert.AreEqual(0, result.Where(a => a.Id == 9).Count());
        }

        [TestMethod]
        public void PageMustCorrectlyBuildLastPage()
        {
            var page = new PageQuery<Art>(10, 1);
            var result = page.Query(_queryable);
            Assert.AreEqual(1, result.Where(a => a.Id == 10).Count());
            Assert.AreEqual(0, result.Where(a => a.Id == 9).Count());
        }

        [TestMethod]
        public void PageMustCorrectlyFetchSome()
        {
            var page = new PageQuery<Art>(1, 100);
            var result = page.Query(_queryable);
            Assert.AreEqual(10, result.Count());
        }

        [TestMethod]
        public void PageMustCorrectlyFetchSomeMidllePages()
        {
            var page = new PageQuery<Art>(2, 3);
            var result = page.Query(_queryable);
            Assert.AreEqual(0, result.Where(a => a.Id == 3).Count());
            Assert.AreEqual(1, result.Where(a => a.Id == 4).Count());
            Assert.AreEqual(1, result.Where(a => a.Id == 5).Count());
            Assert.AreEqual(1, result.Where(a => a.Id == 6).Count());
            Assert.AreEqual(0, result.Where(a => a.Id == 7).Count());
        }
    }
}
