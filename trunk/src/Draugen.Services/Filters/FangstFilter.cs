using System;
using System.Collections.Generic;
using Draugen.Data.Repositories;

namespace Draugen.Services.Filters
{
    public class FangstFilter
    {
        public FangstFilter(IRepository<Fangst> repository)
        {
            
        }

        public IEnumerable<Fangst> FindAll()
        {
            throw new NotImplementedException();
        }
    }

    public class Filter
    {
        public FilterItem OrderBy { get; set; }
        public FilterItem ThenBy { get; set; }
    }

    public class FilterItem
    {
        public string PropertyName { get; set; }
        public Order Order { get; set; }
    }

    public enum Order
    {
        Ascending,
        Descending
    }
}
