using System;

namespace Draugen.Data
{
    public interface IUnitOfWorkFactory : IDisposable
    {
        IUnitOfWork Create();
    }
}