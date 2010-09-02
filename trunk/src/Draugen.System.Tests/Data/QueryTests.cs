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
        private QueryContainer<Fangst> queryContainer;

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
            queryContainer = new QueryContainer<Fangst>();
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

            queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetPage(1, 10);
            var result = queryContainer.Query(_session.Linq<Fangst>());
        }

        [TestMethod]
        public void TestOrder_Vekt()
        {
            queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetSort("Vekt", SortDirection.Descending);
            queryContainer.SetPage(1, 10);

            var result = queryContainer.Query(_session.Linq<Fangst>());
            Assert.IsTrue(result.First().Vekt > 10);
        }

        [TestMethod]
        public void TestOrder_Art()
        {

            queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetSort("Art.Navn", SortDirection.Ascending);
            queryContainer.SetPage(1, 10);
            var result = queryContainer.Query(_session.Linq<Fangst>());
            Assert.AreEqual("Abbor", result.First().Art.Navn);
        }

        [TestMethod]
        public void TestOrder_Poeng()
        {
            queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetSort("Poeng", SortDirection.Descending);
            queryContainer.SetPage(1, 10);
            var result = queryContainer.Query(_session.Linq<Fangst>()).ToArray();
            Assert.AreEqual("Småflekket rødhai", result.First().Art.Navn);
            Assert.AreEqual(10, result.Length);
        }

        [TestMethod]
        public void TestOrder_Poeng_Page5()
        {
            queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetSort("Poeng", SortDirection.Descending);
            queryContainer.SetPage(5, 10);
            var result = queryContainer.Query(_session.Linq<Fangst>()).ToArray();
            Assert.AreEqual(10, result.Length);
        }
    }
}
