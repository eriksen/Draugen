using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Configuration;
using Draugen.Data;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected static IUnityContainer Container;

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

            ConfigureDraugen();
        }

        protected static void ConfigureDraugen()
        {
            var configuration = new DraugenConfiguration(GetConnectionString());
            Container = new GlobalContainer(configuration.GetSessionFactory());

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new DraugenWebFormViewEngine());

            ControllerBuilder.Current.SetControllerFactory(new DraugenControllerFactory(Container));
        }

        protected static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True";
        }
    }
}