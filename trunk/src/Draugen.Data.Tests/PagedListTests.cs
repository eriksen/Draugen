using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Draugen.Data.QueryObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Data
{
    [TestClass]
    public class PagedListTests
    {
        private PagedList<Art> _pagedList;
        private Mock<IQueryManager<Art>> _queryManager;
        private IQueryable<Art> _queryable;
        private Art _art;
        private const int TotalItems = 1;

        [TestInitialize]
        public void InitializeTest()
        {

            _art = new Art();
            _queryable = new List<Art> { _art }.AsQueryable();
            _queryManager = new Mock<IQueryManager<Art>>();
            _queryManager.Setup(q => q.CountTotalItems(It.IsAny<IQueryable<Art>>())).Returns(TotalItems);
            _queryManager.Setup(q => q.Query(It.IsAny<IQueryable<Art>>())).Returns(_queryable);
            _pagedList = new PagedList<Art>(_queryable, _queryManager.Object);
        }

        [TestMethod]
        public void Ctor_MustSetItemCount()
        {
            Assert.AreEqual(TotalItems, _pagedList.TotalItemCount);
        }

        [TestMethod]
        public void Ctor_MustCallQueryOnQueryManager()
        {
            _queryManager.Verify(q => q.Query(_queryable), Times.Once());
        }

        [TestMethod]
        public void Enumerator_MustReturnWhateverReturnedFromQueryManager()
        {
            Assert.IsTrue(_pagedList.Contains(_art));
            Assert.AreEqual(1, _pagedList.Count());
        }

        [TestMethod]
        public void NonGenericEnumerator()
        {
            IEnumerable enumerable = _pagedList.Cast<object>();
            var enumerator = enumerable.GetEnumerator();
        }
    }
}
