using System;
using System.Diagnostics.Contracts;

namespace Draugen.Services.DataBuilders
{

    [ContractClass(typeof(BuilderContract<>))]
    public interface IBuilder<out T> where T : class
    {
        T Build();
    }

    [ContractClassFor(typeof(IBuilder<>))]
    internal abstract class BuilderContract<T> : IBuilder<T> where T : class
    {
        public T Build()
        {
            Contract.Ensures(Contract.Result<T>() != null);
            throw new NotImplementedException();
        }
    }
}