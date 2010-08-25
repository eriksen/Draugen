using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Initialize;
using Microsoft.Practices.Unity;

namespace Draugen
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static IUnityContainer Container;

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
            Container = UnityContainerFactory.Create();

            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new DraugenWebFormViewEngine());

            RegisterControllerFactory();
        }

        private static void RegisterControllerFactory()
        {
            var controllerFactory = Container.Resolve<DraugenControllerFactory>();
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

    }
}