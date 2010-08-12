using System.Linq;

namespace Draugen.Data.Repositories
{
    public interface IRepository<T> where T : Kommenterbar
    {
        IQueryable<T> FindAll();
        void SaveOrUpdate(T item);
        void Delete(T item);
    }
}
