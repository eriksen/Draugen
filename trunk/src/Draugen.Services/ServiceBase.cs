using System.Diagnostics.Contracts;
using Draugen.Data;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public abstract class ServiceBase
    {
        protected IUnityContainer Container;
        protected IUnitOfWorkFactory UnitOfWorkFactory;

        protected ServiceBase(IUnityContainer container)
        {
            Contract.Requires(container != null);
            Container = container;
            UnitOfWorkFactory = container.Resolve<IUnitOfWorkFactory>();
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Container != null);
            Contract.Invariant(UnitOfWorkFactory != null);
        }

    }
}