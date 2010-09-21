using System.Web.Mvc;
using System.Web.Routing;

namespace Draugen.Routes
{
    public class RouteBuilder
    {
        public void Build(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Art",
                "{culture}/{controller}/{name}/{page}",
                new { action = "Detaljer", page = "1" }
                );

            routes.MapRoute(
                "Default", // Route name
                "{culture}/{controller}/{action}/{page}", // URL with parameters
                new { culture = "no", controller = "Hjem", action = "Fangster", page = "1" } // Parameter defaults
            );
        }
    }
}