using System.Collections;
using System.Collections.Generic;

namespace Draugen.Data.Repositories
{
    public class DomainList<T> : IDomainList
    {
        private readonly IEnumerable<T> _list;

        public DomainList(IEnumerable<T> items)
        {
            _list = items;    
        }

        public int Count { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}