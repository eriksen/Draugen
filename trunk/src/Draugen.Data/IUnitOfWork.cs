using System;
using NHibernate;

namespace Draugen.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ISession Session { get; }
    }
}