using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> FindAll();
        Task<T> FindById(int id);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Save();
    }
}