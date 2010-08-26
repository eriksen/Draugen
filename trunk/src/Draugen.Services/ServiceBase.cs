using System.Diagnostics.Contracts;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public abstract class ServiceBase
    {
        protected IUnityContainer Container;

        protected ServiceBase(IUnityContainer container)
        {
            Contract.Requires(container != null);
            Container = container;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Container != null);
        }

    }
}