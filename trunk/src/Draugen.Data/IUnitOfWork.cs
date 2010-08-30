using System;
using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    [ContractClass(typeof(UnitOfWorkContracts))]
    public interface IUnitOfWork : IDisposable
    {
        ISession Session { get; }
    }

    [ContractClassFor(typeof(IUnitOfWork))]
    internal abstract class UnitOfWorkContracts : IUnitOfWork
    {
        public ISession Session
        {
            get
            {
                return default(ISession);
            }
        }

        public void Dispose()
        {
            
        }
    }
}