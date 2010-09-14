using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{
    [TestClass]
    public class QueryManagerTests
    {
        private QueryManager<Art> _queryManager;
        private IQueryable<Art> _queryable;
        private Art _art1;
        private Art _art2;
        private Art _art3;
        private Art _art4;

        [TestInitialize]
        public void InitializeTest()
        {
            _queryManager = new QueryManager<Art>();
            _art1 = new Art { Id = 4, Navn = "A", Rekord = 2.5 };
            _art2 = new Art { Id = 3, Navn = "A", Rekord = 2.6 };
            _art3 = new Art { Id = 2, Navn = "B", Rekord = 2.4 };
            _art4 = new Art { Id = 1, Navn = "C", Rekord = 2.8 };
            _queryable = new List<Art> { _art1, _art2, _art3, _art4 }.AsQueryable();
        }

        [TestMethod]
        public void PageIndex_MustReturnIndexOfPageQuery()
        {
            _queryManager.SetPage(100, 1);
            Assert.AreEqual(100, _queryManager.PageIndex);
        }

        [TestMethod]
        public void PageSize_MustReturnSizeOfPageQuery()
        {
            _queryManager.SetPage(1, 100);
            Assert.AreEqual(100, _queryManager.PageSize);
        }

        [TestMethod]
        public void CountAllItems_MustReturnACountOfAllHitsMatchingTheCriteria()
        {
            _queryManager.AddFilter("Navn", FilterOperator.Equals, "B");
            Assert.AreEqual(1, _queryManager.TotalItemsCount(_queryable));
        }

        [TestMethod]
        public void AddFilter_MustAddFilterToResultset()
        {
            _queryManager.AddFilter("Navn", FilterOperator.Equals, "A");
            Assert.AreEqual(2, _queryManager.TotalItemsCount(_queryable));
        }

        [TestMethod]
        public void SetPage_MustReturnWantedPage()
        {
            _queryManager.SetPage(2, 2);
            var result = _queryManager.Query(_queryable);
            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Contains(_art3));
            Assert.IsTrue(result.Contains(_art4));
        }

        [TestMethod]
        public void SetPage_MustStillReturnFullCount()
        {
            _queryManager.SetPage(2, 2);
            Assert.AreEqual(4, _queryManager.TotalItemsCount(_queryable));
            Assert.AreEqual(2, _queryManager.Query(_queryable).Count());
        }

        [TestMethod]
        public void SetSort_MustSortInWantedDirection()
        {
            _queryManager.SetSort("Navn", SortDirection.Descending);
            var result = _queryManager.Query(_queryable).ToArray();
            Assert.AreSame(_art4, result[0]);
            Assert.AreSame(_art3, result[1]);
        }

        [TestMethod]
        public void Query_MustApplyAllFiltersAtOnce()
        {
            _queryManager.SetSort("Navn", SortDirection.Ascending);
            _queryManager.AddFilter("Rekord", FilterOperator.GreaterThan, 2.5);
            _queryManager.SetPage(2, 1);
            var result = _queryManager.Query(_queryable).ToArray();
            Assert.AreEqual(2, _queryManager.TotalItemsCount(_queryable));
            Assert.AreEqual(1, result.Length);
            Assert.IsTrue(result.Contains(_art4));
        }
        
        [TestMethod]
        public void Validate_MustValidatePage()
        {
            _queryManager.Validate();
        }

        [TestMethod]
        public void Validate_MustValidateSort()
        {
            _queryManager.Validate();
        }

        [TestMethod]
        public void Validate_MustValidateFilter()
        {
            _queryManager.AddFilter("Navn", FilterOperator.Equals, "navn");
            _queryManager.Validate();
        }
        
        [TestMethod]
        public void Ctor_MustSetDefaultSortToIdAscending()
        {
            var result = _queryManager.Query(_queryable);
            Assert.AreSame(_art1, result.First());
        }

        [TestMethod]
        public void CTor_MustSetDefaultPageTo1AndSizeToMaxint()
        {
            var result = _queryManager.Query(_queryable);
            Assert.AreEqual(4, result.Count());
        }
    }
}
