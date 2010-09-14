using System.Collections.Generic;
using System.Linq;
using Draugen.Data.QueryObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Data.Paging
{
    [TestClass]
    public class PageBuilderTests
    {
        private Mock<IQueryManager<Fangst>> _queryManagerFake;
        private IQueryable<Fangst> _queryable;
        private PageBuilder<Fangst> _pageBuilder;
        private QueryManager<Fangst> _queryManager;

        [TestInitialize]
        public void InitializeTest()
        {
            _queryManagerFake = new Mock<IQueryManager<Fangst>>();
            _queryManager = new QueryManager<Fangst>();
            _queryable = new List<Fangst>() { new Fangst(), new Fangst() }.AsQueryable();
            _queryManagerFake.Setup(q => q.Query(_queryable)).Returns(_queryable);
            _pageBuilder = new PageBuilder<Fangst>();
        }

        [TestMethod]
        public void Build_MustSetTotalItemsToPageCount_WhenIQueryManagerIsNotTypeOfQueryManager()
        {
            var result = _pageBuilder.Build(_queryManagerFake.Object, _queryable);
            Assert.AreEqual(2, result.TotalItems);
        }

        [TestMethod]
        public void Build_MustSetTotalItemsToCountReturnedFromQueryManager()
        {
            _queryManager.SetPage(1, 1);
            var result = _pageBuilder.Build(_queryManager, _queryable);
            Assert.AreEqual(2, result.TotalItems);
        }

        [TestMethod]
        public void Build_MustSetSizeToPageCount_WhenIQueryManagerIsNotTypeOfQueryManager()
        {
            var result = _pageBuilder.Build(_queryManagerFake.Object, _queryable);
            Assert.AreEqual(2, result.Size);
        }

        [TestMethod]
        public void Build_MustSetSizeTo1_WhenQueryContainsZeroHits()
        {
            var result = _pageBuilder.Build(_queryManagerFake.Object, new List<Fangst>(){}.AsQueryable());
            Assert.AreEqual(1, result.Size);
        }

        [TestMethod]
        public void Build_MustSetSizeFromPage_WHenTypeofQueryManager()
        {
            _queryManager.SetPage(1, 1);
            var result = _pageBuilder.Build(_queryManager, _queryable);
            Assert.AreEqual(1, result.Size);
        }

        [TestMethod]
        public void Build_MustSetIndexTo1_WhenNotQueryManager()
        {
            var result = _pageBuilder.Build(_queryManagerFake.Object, _queryable);
            Assert.AreEqual(1, result.Index);
        }

        [TestMethod]
        public void Build_MustSetIndexFromPage_WHenQueryManager()
        {
            _queryManager.SetPage(2, 1);
            var result = _pageBuilder.Build(_queryManager, _queryable);
            Assert.AreEqual(2, result.Index);
        }

        [TestMethod]
        public void Build_MustAddItemsReturnedFromQueryManager()
        {
            var result = _pageBuilder.Build(_queryManagerFake.Object, _queryable);
            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Contains(_queryable.First()));
            Assert.IsTrue(result.Contains(_queryable.Last()));
        }

    }
}
