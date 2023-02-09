using SalesOrderManager.Server.Repositories;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<Order>> Get()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<Order> Get(int orderId)
        {
            return await _orderRepository.GetOrder(orderId);
        }
        public async Task Delete(int id)
        {
            await _orderRepository.Delete(id);
        }

        public async Task Add(Order order)
        {
            await _orderRepository.Add(order);
        }

        public async Task Update(Order order)
        {
            await _orderRepository.Update(order);
        }
    }
}
