using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace Draugen.Web
{
    public class DraugenControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null) { return null; }

            var container = new DraugenUnityContainer();
            requestContext.HttpContext.Items["UnityContainer"] = container;
            return container.Resolve(controllerType) as IController;
        }
    }
}