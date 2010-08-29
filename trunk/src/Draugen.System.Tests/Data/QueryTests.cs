using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Services.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draugen.Configuration;
using Microsoft.Practices.Unity;
using NHibernate;
using NHibernate.Linq;

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
                Sort = new Sort("Vekt", SortDirection.Descending),
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
                Sort = new Sort("Art.Navn", SortDirection.Ascending),
                Page = new Page(1, 10)
            };
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual("Abbor", result.First().Art.Navn);
        }

        [TestMethod]
        public void TestOrder_Poeng()
        {
            var query = new Query
            {
                Sort = new Sort("Poeng", SortDirection.Descending),
                Page = new Page(1, 10)
            };
            query.AddFilter(new Filter("Art.Id", FilterOperator.GreaterThan, 0));
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual("Småflekket rødhai", result.First().Art.Navn);
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_Poeng_Page5()
        {
            var query = new Query
            {
                Sort = new Sort("Poeng", SortDirection.Descending),
                Page = new Page(10, 10)
            };
            query.AddFilter(new Filter("Art.Id", FilterOperator.GreaterThan, 0));
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_WithOrderOfQueries()
        {
            var queries = new QueryObjects.IQueryObject[]
                              {
                                  new Sort("Poeng", SortDirection.Descending),
                                  new Sort("Art.Navn", SortDirection.Descending),
                                  new Filter("Vekt", FilterOperator.GreaterThan, 2),
                                  new Filter("Art.Id", FilterOperator.GreaterThan, 0),
                                  
                              };
            IQueryable<Fangst> result = _session.Linq<Fangst>();
            
            foreach (var query in queries)
            {
                result = result.Query(query);    
            }
            var list = result.ToArray();
            
            Assert.AreEqual(5, list.Length);
        }
    }
}
