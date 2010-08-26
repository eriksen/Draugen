using System;
using NHibernate;

namespace Draugen.Data
{
    public interface IDraugenConfiguration : IDisposable
    {
        ISessionFactory GetSessionFactory();
    }
}