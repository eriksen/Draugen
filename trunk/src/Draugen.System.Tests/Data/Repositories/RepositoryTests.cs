using System.Linq;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;

namespace Draugen.Data.Repositories
{
    [TestClass]
    public class RepositoryTests
    {
        private static ISession _session;
        private static DraugenConfiguration _configuration;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _configuration = new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            _session = _configuration.GetSessionFactory().OpenSession();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _session.Dispose();
            _session = null;
            _configuration.Dispose();
            _configuration = null;
        }

        [TestMethod]
        public void FindAllArt()
        {
            var result = FindAll<Art>();
            Assert.IsTrue(result.Count() >= 53);
        }

        [TestMethod]
        public void FindAllSted()
        {
            var result = FindAll<Sted>();
            Assert.IsTrue(result.Count() >= 62);
        }

        [TestMethod]
        public void FindAllFisker()
        {
            var result = FindAll<Fisker>();
            Assert.IsTrue(result.Count() >= 22);
        }

        [TestMethod]
        public void FindAllTeam()
        {
            var result = FindAll<Team>();
            Assert.IsTrue(result.Count() >= 1);
        }

        [TestMethod]
        [ExpectedException(typeof(NHibernate.ADOException))]
        public void FindAllFangst_WithGenericRepository_ShouldFail()
        {
            FindAll<Fangst>();
        }

        [TestMethod]
        public void FindAllFangst_WillSucceedWithFangstRepository()
        {
            var pageBuilder = new PageBuilder<Fangst>();
            var repository = new FangstRepository(_session, pageBuilder);
            var result = repository.FindAll(new QueryManager<Fangst>());
            Assert.IsTrue(result.Count() >= 382);
        }


        private static IPage<T> FindAll<T>() where T : Kommenterbar
        {
            return FindAll(new QueryManager<T>());
        }

        private static IPage<T> FindAll<T>(IQueryManager<T> queryManager) where T : Kommenterbar
        {
            var pageBuilder = new PageBuilder<T>();
            var repository = new Repository<T>(_session, pageBuilder);
            return repository.FindAll(queryManager);
        }

    }
}
