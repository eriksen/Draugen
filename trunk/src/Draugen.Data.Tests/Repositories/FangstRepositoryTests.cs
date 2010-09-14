using System.Collections.Generic;
using System.Linq;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using Draugen.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Data.Repositories
{
    [TestClass]
    public class FangstRepositoryTests
    {
        private FangstRepository _repository;
        private Mock<IQueryManager<Fangst>> _queryManager;
        private Fangst _fangst;
        private Mock<IPageBuilder<Fangst>> _pageBuilder;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangst = new Fangst();
            var queryable = new List<Fangst> {_fangst}.AsQueryable();
            var session = MyMocks.Session();
            _pageBuilder = new Mock<IPageBuilder<Fangst>>();
            _pageBuilder.Setup(p => p.Build(It.IsAny<IQueryManager<Fangst>>(), It.IsAny<IQueryable<Fangst>>()))
                .Returns(new Page<Fangst>() { _fangst });
            _repository = new FangstRepository(session.Object, _pageBuilder.Object);
            _queryManager = new Mock<IQueryManager<Fangst>>();
            _queryManager.Setup(q => q.Query(It.IsAny<IQueryable<Fangst>>())).Returns(queryable);
        }

        [TestMethod]
        public void FilterHack_MustBeAddedToQueryManager()
        {
            _repository.FindAll(_queryManager.Object);
            _queryManager.Verify(q => q.AddFilter("Art.Id", FilterOperator.GreaterThan, 0), Times.Once());
        }

        [TestMethod]
        public void FindAll_MustReturnListReturnedFromBase()
        {
            var result = _repository.FindAll(_queryManager.Object);
            Assert.IsTrue(result.Contains(_fangst));
            Assert.AreEqual(1, result.Count());
        }
    }
}
