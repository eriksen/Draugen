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

        [TestInitialize]
        public void Initialize()
        {
            var unitOfWorkFactoryMock = new Mock<IUnitOfWorkFactory>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            _sessionMock = new Mock<ISession>();
            unitOfWorkFactoryMock.Setup(u => u.Create()).Returns(unitOfWorkMock.Object);
            unitOfWorkMock.Setup(u => u.Session).Returns(_sessionMock.Object);
            _repository = new Repository<Sted>(unitOfWorkFactoryMock.Object);

        }
        
        [TestMethod]
        public void FindAll_MustCallSessionLinq()
        {
            var result =  _repository.FindAll();
            Assert.IsInstanceOfType(result, typeof(Query<Sted>));
        }

        [TestMethod]
        public void Add_MustSaveOrUpdateAllKommentarerFromItem()
        {
            var kommentar1 = new Kommentar();
            var kommentar2 = new Kommentar();
            var sted = new Sted {Kommentarer = new[] {kommentar1, kommentar2}};
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
