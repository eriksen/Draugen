using System;
using NHibernate;

namespace Draugen.Data
{
    public interface ISessionManager : IDisposable
    {
        ISession Session { get; }
    }
}