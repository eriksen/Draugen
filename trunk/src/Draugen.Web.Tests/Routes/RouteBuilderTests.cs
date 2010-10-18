using System.Web;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Routes
{
    [TestClass]
    public class RouteBuilderTests
    {
        private RouteCollection _routes;
        private RouteBuilder _builder;

        [TestInitialize]
        public void InitializeTest()
        {
            _routes = new RouteCollection();
            _builder = new RouteBuilder();
            _builder.Build(_routes);
        }

        #region Default

        [TestMethod]
        public void TestDefaultRoute()
        {
            VerifyDefaultRoute("~/");
            VerifyDefaultRoute("~/no/hjem/fangster/1/");
        }

        private void VerifyDefaultRoute(string url, string culture = "no", string controller = "hjem", string action = "fangster", string page = "1", string period = "alltid")
        {
            var routeData = GetRouteDataForUrl(url, _routes);
            Assert.AreEqual(((Route)routeData.Route).Url, "{culture}/{controller}/{action}/{page}/{period}");
            Assert.AreEqual(culture, routeData.Values["culture"]);
            Assert.AreEqual(controller, routeData.Values["controller"]);
            Assert.AreEqual(action, routeData.Values["action"]);
            Assert.AreEqual(page, routeData.Values["page"]);
            Assert.AreEqual(period, routeData.Values["period"]);
            Assert.AreEqual(5, routeData.Values.Count);
        }
        #endregion

        #region Sted
        [TestMethod]
        public void StedRouteTest()
        {
            VerifyStedRoute("~/no/sted/detaljer/torsk/1/");
        }

        private void VerifyStedRoute(string url, string culture = "no", string controller = "sted", string action = "detaljer", string name = "torsk", string page = "1", string period = "alltid")
        {
            var routeData = GetRouteDataForUrl(url, _routes);
            Assert.AreEqual("{culture}/{controller}/{action}/{name}/{page}/{period}", ((Route)routeData.Route).Url);
            Assert.AreEqual(culture, routeData.Values["culture"]);
            Assert.AreEqual(controller, routeData.Values["controller"]);
            Assert.AreEqual(action, routeData.Values["action"]);
            Assert.AreEqual(name, routeData.Values["name"]);
            Assert.AreEqual(page, routeData.Values["page"]);
            Assert.AreEqual(period, routeData.Values["period"]);
            Assert.AreEqual(6, routeData.Values.Count);
        }

        #endregion

        private static RouteData GetRouteDataForUrl(string url, RouteCollection routes)
        {
            var httpContext = new Mock<HttpContextBase>();
            httpContext.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns(url);

            var routeData = routes.GetRouteData(httpContext.Object);
            Assert.IsNotNull(routeData);
            return routeData;
        }
    }
}
