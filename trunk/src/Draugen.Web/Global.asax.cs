﻿using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Data;
using Draugen.Web.Setup;
using Microsoft.Practices.Unity;

namespace Draugen.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
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

            RegisterControllerFactory();
        }

        private static void RegisterControllerFactory()
        {
            var configuration = new DraugenConfiguration("Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True");
            var container = new DraugenUnityContainer(configuration.GetSessionFactory());
            var controllerFactory = container.Resolve<DraugenControllerFactory>();
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}