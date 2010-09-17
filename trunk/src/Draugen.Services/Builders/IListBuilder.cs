using System.Diagnostics.Contracts;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    [ContractClass(typeof(ListBuilderContract<>))]
    public interface IListBuilder<out T> where T : class
    {
        T Build(ServiceHeader header);
    }

    [ContractClassFor(typeof(IListBuilder<>))]
    public abstract class ListBuilderContract<T> : IListBuilder<T> where T : class
    {
        public T Build(ServiceHeader header)
        {
            Contract.Requires(header != null);
            Contract.Requires(header.Culture != null);

            Contract.Ensures(Contract.Result<T>() != null);

            return default(T);
        }
    }
}