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
            VerifyDefaultRoute("~/no/Hjem/Fangster/22", page: "22");
        }

        private void VerifyDefaultRoute(string url, string culture = "no", string controller = "Hjem", string action = "Fangster", string page = "1")
        {
            var routeData = GetRouteDataForUrl(url, _routes);
            Assert.AreEqual(((Route)routeData.Route).Url, "{culture}/{controller}/{action}/{page}");
            Assert.AreEqual(culture, routeData.Values["culture"]);
            Assert.AreEqual(controller, routeData.Values["controller"]);
            Assert.AreEqual(action, routeData.Values["action"]);
            Assert.AreEqual(page, routeData.Values["page"]);
            Assert.AreEqual(4, routeData.Values.Count);
        }
        #endregion

        #region Art
        [TestMethod]
        public void ArtRouteTest()
        {
            VerifyArtRoute("~/no/Art/Torsk/");
        }

        private void VerifyArtRoute(string url, string culture = "no", string controller = "Art", string name = "Torsk", string page = "1")
        {
            var routeData = GetRouteDataForUrl(url, _routes);
            Assert.AreEqual("{culture}/{controller}/{name}/{page}", ((Route)routeData.Route).Url);
            Assert.AreEqual(culture, routeData.Values["culture"]);
            Assert.AreEqual(controller, routeData.Values["controller"]);
            Assert.AreEqual("Detaljer", routeData.Values["action"]);
            Assert.AreEqual(name, routeData.Values["name"]);
            Assert.AreEqual(page, routeData.Values["page"]);
            Assert.AreEqual(5, routeData.Values.Count);
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
