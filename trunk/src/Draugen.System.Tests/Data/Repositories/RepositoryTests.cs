using Draugen.Data.QueryObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;

namespace Draugen.Data.Repositories
{
    [TestClass]
    public class RepositoryTests
    {
        private static ISession _session;
        private static Repository<Art> _repository;
        private static QueryManager<Art> _queryManager;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var configuration = new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            _session = configuration.GetSessionFactory().OpenSession();
            _repository = new Repository<Art>(_session);
            _queryManager = new QueryManager<Art>();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _session.Dispose();
            _session = null;
        }

        [TestMethod]
        public void FindAll()
        {
            
            var result = _repository.FindAll(_queryManager);
        }
    }
}
