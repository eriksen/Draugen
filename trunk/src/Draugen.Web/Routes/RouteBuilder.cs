using System.Web.Mvc;
using System.Web.Routing;

namespace Draugen.Routes
{
    public class RouteBuilder
    {
        private const string Cultures = "no";
        private const string Page = @"\d+";
        private const string Period = @"(alltid|høst|vinter|vår|sommer)|\d{4}";

        public void Build(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Fangster",
                "{culture}/{controller}/{action}/{name}/{page}/{period}",
                new {period = "alltid"},
                new
                    {
                        culture = Cultures,
                        controller = "team|fisker|sted",
                        action = "fangster|rekorder|detaljer",
                        page = Page,
                        period = Period
                    }
                );

            routes.MapRoute(
                "Default", // Route name
                "{culture}/{controller}/{action}/{page}/{period}", // URL with parameters
                new {culture = "no", controller = "hjem", action = "fangster", page = "1", period = "alltid"},
                new {culture = Cultures, controller = "hjem", action = "fangster", page = Page, period = Period}
                );
        }
    }
}