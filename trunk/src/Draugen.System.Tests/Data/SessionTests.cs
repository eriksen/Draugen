using System.Linq;
using Draugen.Data.QueryObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Linq;
using NHibernate;


namespace Draugen.Data
{
    [TestClass]
    public class SessionTests
    {
        private static ISession _session;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var configuration = new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            _session = configuration.GetSessionFactory().OpenSession();
            //_session.BeginTransaction();

        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _session.Dispose();
        }

        [TestMethod]
        public void CanLoadKommentar()
        {
            var result = _session.Linq<Kommentar>().ToArray();
        }


        [TestMethod]
        public void CanLoadArt()
        {
            var result = _session.Linq<Art>().ToArray();
        }

        [TestMethod]
        public void CanLoadSted()
        {
            var result = _session.Linq<Sted>().ToArray();
        }

        [TestMethod]
        public void CanLoadTeam()
        {
            var result = _session.Linq<Team>().ToArray();
        }

        [TestMethod]
        public void CanLoadFisker()
        {
            var result = _session.Linq<Fisker>().ToArray();
        }
        
        [TestMethod]
        public void CanLoadFangst()
        {
            var queries = new IQueryObject[] {new Filter("Art.Id", FilterOperator.GreaterThan, 0)};
            var result = _session.Linq<Fangst>().Query(queries).ToArray();

        }
    }
}
