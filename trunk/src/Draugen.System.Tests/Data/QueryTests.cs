using System.Collections.Generic;
using System.Linq;
using Draugen.Data.QueryObjects;
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
        private static IUnityContainer _perCallContainer;
        private static List<IQueryObject> _queryObjects;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var container = new GlobalContainer(new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True").GetSessionFactory());
            var serviceContainer = container.Resolve<IUnityContainer>("Service");
            _perCallContainer = serviceContainer.Resolve<IUnityContainer>();
            _session = _perCallContainer.Resolve<ISession>();
        }

        [TestInitialize]
        public void InitializeTest()
        {
            _queryObjects = new List<IQueryObject>() { new Filter("Art.Id", FilterOperator.GreaterThan, 0) };
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _perCallContainer.Dispose();
            _perCallContainer = null;
        }

        [TestMethod]
        public void TestPaging()
        {
            _queryObjects.Add(new Page(1, 10));
            var result = _session.Linq<Fangst>().Query(_queryObjects.ToArray());
        }

        [TestMethod]
        public void TestOrder_Vekt()
        {
            _queryObjects.AddRange(new IQueryObject[] { new Page(1, 10), new Sort("Vekt", SortDirection.Descending) });

            var result = _session.Linq<Fangst>().Query(_queryObjects.ToArray());
            Assert.IsTrue(result.First().Vekt > 10);
        }

        [TestMethod]
        public void TestOrder_Art()
        {

            _queryObjects.AddRange(new IQueryObject[] 
            {
                new Sort("Art.Navn", SortDirection.Ascending),
                new Page(1, 10)
            });
            var result = _session.Linq<Fangst>().Query(_queryObjects.ToArray()).ToArray();
            Assert.AreEqual("Abbor", result.First().Art.Navn);
        }

        [TestMethod]
        public void TestOrder_Poeng()
        {
            _queryObjects.AddRange(new IQueryObject[] 
            {
                new Sort("Poeng", SortDirection.Descending),
                new Page(1, 10),
            });
            var result = _session.Linq<Fangst>().Query(_queryObjects.ToArray()).ToArray();
            Assert.AreEqual("Småflekket rødhai", result.First().Art.Navn);
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_Poeng_Page5()
        {
            _queryObjects.AddRange( new IQueryObject[] 
            {
                new Sort("Poeng", SortDirection.Descending),
                new Page(10, 10),
            });
            var result = _session.Linq<Fangst>().Query(_queryObjects.ToArray()).ToArray();
            Assert.AreEqual(10, result.Length);
        }
    }
}
