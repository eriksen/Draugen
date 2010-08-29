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
            var list = new IQueryObject[] {new Page(1, 10)};

            var result = _session.Linq<Fangst>().Query<Fangst>(list);
            Assert.AreEqual(10, result.ToArray().Count());
        }

        [TestMethod]
        public void TestOrder_Vekt()
        {
            var list = new IQueryObject[] { new Page(1, 10), new Sort("Vekt", SortDirection.Descending) };

            var result = _session.Linq<Fangst>().Query(list);
            Assert.IsTrue(result.First().Vekt > 10);
        }

        [TestMethod]
        public void TestOrder_Art()
        {

            var query = new IQueryObject[] 
            {
                new Sort("Art.Navn", SortDirection.Ascending),
                new Page(1, 10)
            };
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual("Abbor", result.First().Art.Navn);
        }

        [TestMethod]
        public void TestOrder_Poeng()
        {
            var query = new IQueryObject[] 
            {
                new Sort("Poeng", SortDirection.Descending),
                new Page(1, 10),
                new Filter("Art.Id", FilterOperator.GreaterThan, 0)
            };
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual("Småflekket rødhai", result.First().Art.Navn);
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_Poeng_Page5()
        {
            var query = new IQueryObject[] 
            {
                new Sort("Poeng", SortDirection.Descending),
                new Page(10, 10),
                new Filter("Art.Id", FilterOperator.GreaterThan, 0)
            };
            var result = _session.Linq<Fangst>().Query(query).ToArray();
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_WithOrderOfQueries()
        {
            var queries = new IQueryObject[]
                              {
                                  new Sort("Poeng", SortDirection.Descending),
                                  new Sort("Art.Navn", SortDirection.Descending),
                                  new Filter("Vekt", FilterOperator.GreaterThan, 2),
                                  new Filter("Art.Id", FilterOperator.GreaterThan, 0),
                                  
                              };
            IQueryable<Fangst> result = _session.Linq<Fangst>();
            result = result.Query(queries); 

            var list = result.ToArray();
            
            Assert.AreEqual(5, list.Length);
        }
    }
}
