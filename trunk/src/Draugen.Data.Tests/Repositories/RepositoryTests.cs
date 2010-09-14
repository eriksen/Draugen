using System.Linq;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using Draugen.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using NHibernate.Linq;

namespace Draugen.Data.Repositories
{
    [TestClass]
    public class RepositoryTests
    {
        private Repository<Sted> _repository;
        private Mock<ISession> _sessionMock;
        private Mock<IQueryManager<Sted>> _queryContainer;
        private Mock<IPageBuilder<Sted>> _pageBuilder;

        [TestInitialize]
        public void Initialize()
        {
            _sessionMock = MyMocks.Session();
            _pageBuilder = new Mock<IPageBuilder<Sted>>();
            _pageBuilder.Setup(p => p.Build(It.IsAny<IQueryManager<Sted>>(), It.IsAny<IQueryable<Sted>>()))
                .Returns(new Page<Sted>());
            _repository = new Repository<Sted>(_sessionMock.Object, _pageBuilder.Object);
            _queryContainer = new Mock<IQueryManager<Sted>>();
            
        }

        [TestMethod]
        public void FindAll_MustReturnListFromSessionLinq()
        {
            _repository.FindAll(_queryContainer.Object);
        }

        [TestMethod]
        public void Add_MustSaveOrUpdateAllKommentarerFromItem()
        {
            var kommentar1 = new Kommentar();
            var kommentar2 = new Kommentar();
            var sted = new Sted { Kommentarer = new[] { kommentar1, kommentar2 }.ToList() };
            _repository.Add(sted);
            _sessionMock.Verify(s => s.SaveOrUpdate(kommentar1));
            _sessionMock.Verify(s => s.SaveOrUpdate(kommentar2));
        }

        [TestMethod]
        public void Add_MustSaveOrUpdateItem()
        {
            var item = new Sted();
            _repository.Add(item);
            _sessionMock.Verify(s => s.SaveOrUpdate(item));
        }

        [TestMethod]
        public void Add_MustDeleteItem()
        {
            var item = new Sted();
            _repository.Delete(item);
            _sessionMock.Verify(s => s.Delete(item));
        }
    }
}
