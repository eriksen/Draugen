using System.Diagnostics.Contracts;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public abstract class ServiceBase
    {
        protected IUnityContainer GlobalContainer;

        protected ServiceBase(IUnityContainer globalContainer)
        {
            Contract.Requires(globalContainer != null);
            GlobalContainer = globalContainer;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(GlobalContainer != null);
        }

    }
}