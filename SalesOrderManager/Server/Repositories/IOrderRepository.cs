using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetOrder(int orderId);
    }
}
