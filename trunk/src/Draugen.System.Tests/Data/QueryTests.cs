using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Services.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draugen.Configuration;
using Microsoft.Practices.Unity;
using NHibernate;
using NHibernate.Linq;
using Order = Draugen.Data.QueryObjects.Order;

namespace Draugen.Data
{
    [TestClass]
    public class QueryTests
    {
        private static ISession _session;
        private static ILocalContainer _localContainer;
        private static GlobalContainer _container;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _container = new GlobalContainer(new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True").GetSessionFactory());
            _localContainer = _container.Resolve<ILocalContainer>();
            _session = _localContainer.Resolve<ISession>();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _localContainer.Dispose();
            _localContainer = null;
            _container.Dispose();
            _container = null;
        }

        [TestMethod]
        public void TestPaging()
        {

            var query = new Query
                            {
                                Page = new Page(1, 10)
                            };
            var result = _session.Linq<Fangst>().Query(query);
            Assert.AreEqual(10, result.ToArray().Count());
        }

        [TestMethod]
        public void TestOrder_Vekt()
        {

            var query = new Query
            {
                Order = new Order("Vekt", SortDirection.Descending),
                Page = new Page(1, 10)
            };
            var result = _session.Linq<Fangst>().Query(query);
            Assert.IsTrue(result.First().Vekt > 10);
        }

        [TestMethod]
        public void TestOrder_Art()
        {

            var query = new Query
            {
                Order = new Order("Art.Navn", SortDirection.Ascending),
                Page = new Page(1, 10)
            };
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual("Abbor", result);
        }

        [TestMethod]
        public void TestOrder_Poeng()
        {
            var query = new Query
            {
                Order = new Order("Poeng", SortDirection.Descending),
                Page = new Page(1, 10)
            };
            _session.CreateCriteria<Fangst>();
            var result = _session.Linq<Fangst>().Query(query).Where(f => f.Art.Navn != null).ToArray();
            Assert.AreEqual("Småflekket rødhai", result.First().Art.Navn);
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_Poeng_Page5()
        {
            var query = new Query
            {
                Order = new Order("Poeng", SortDirection.Descending),
                Page = new Page(10, 10)
            };
            _session.CreateCriteria<Fangst>();
            var result = _session.Linq<Fangst>().Query(query).Where(f => f.Art.Navn != null).ToArray();
            Assert.AreEqual(10, result.Length);
        }

    }
}
