using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public interface IOrderService
    {
        Task<List<Order>> Get();
        Task<Order> Get(int id);
        Task Delete(int id);
        Task Add(Order order);
        Task Update(Order order);
    }
}
