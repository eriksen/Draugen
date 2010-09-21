using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Configuration;
using Draugen.Data;
using Draugen.Routes;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected static IUnityContainer Container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            var routeBuilder = new RouteBuilder();
            routeBuilder.Build(RouteTable.Routes);

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