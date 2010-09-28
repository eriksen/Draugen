using System.Diagnostics.Contracts;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    [ContractClass(typeof(ListBuilderContract<>))]
    public interface IListBuilder<out T> where T : class
    {
        T Build(string culture, int page);
    }

    [ContractClassFor(typeof(IListBuilder<>))]
    public abstract class ListBuilderContract<T> : IListBuilder<T> where T : class
    {
        public T Build(string culture, int page)
        {
            Contract.Requires(culture != null);

            Contract.Ensures(Contract.Result<T>() != null);

            return default(T);
        }
    }
}