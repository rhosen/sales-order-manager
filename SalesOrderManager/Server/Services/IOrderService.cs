using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public interface IOrderService
    {
        Task<List<Order>> Get();
        Task<Order> Get(int orderId);
        Task Delete(int id);
        Task Update(Order order);
    }
}
