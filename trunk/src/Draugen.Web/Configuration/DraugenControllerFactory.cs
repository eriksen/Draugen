using System;
using System.Diagnostics.Contracts;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace Draugen.Configuration
{
    public class DraugenControllerFactory : DefaultControllerFactory
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_container != null);
        }
        private readonly IUnityContainer _container;

        public DraugenControllerFactory(IUnityContainer container)
        {
            Contract.Requires(container != null);
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null) { return null; }

            return _container.Resolve(controllerType) as IController;
        }
    }
}