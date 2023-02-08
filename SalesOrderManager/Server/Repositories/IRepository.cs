using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesOrderManager.Server.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
