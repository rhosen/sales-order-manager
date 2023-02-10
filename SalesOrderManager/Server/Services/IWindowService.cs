using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public interface IWindowService
    {
        Task Delete(int id);
        Task<List<Window>> Get();
        Task<Window> Add(Window window);
    }
}
