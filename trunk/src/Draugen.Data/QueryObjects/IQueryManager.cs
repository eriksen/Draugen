using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    [ContractClass(typeof(QueryManagerContracts<>))]
    public interface IQueryManager<T> : IQueryObject<T> where T : DomainObject
    {
        void AddFilter(string property, FilterOperator filterOperator, object value);
        void SetPage(int pageIndex, int pageSize);
        void SetSort(string property, SortDirection direction);
    }

    [ContractClassFor(typeof(IQueryManager<>))]
    internal abstract class QueryManagerContracts<T> : IQueryManager<T> where T : DomainObject
    {
        internal int TotalItemsCount(IQueryable<T> queryable)
        {
            Contract.Requires(queryable != null);
            Contract.Ensures(Contract.Result<int>() >= 0);
            return default(int); 
        }

        public void AddFilter(string property, FilterOperator filterOperator, object value)
        {
            Contract.Requires(string.IsNullOrWhiteSpace(property) == false);
            Contract.Requires(value != null);
        }

        public void SetPage(int pageIndex, int pageSize)
        {
            Contract.Requires(pageIndex > 0);
            Contract.Requires(pageSize > 0);
        }

        public void SetSort(string property, SortDirection direction)
        {
            Contract.Requires(string.IsNullOrWhiteSpace(property) == false);
        }

        public abstract IQueryable<T> Query(IQueryable<T> queryable);
        public abstract void Validate();
    }
}