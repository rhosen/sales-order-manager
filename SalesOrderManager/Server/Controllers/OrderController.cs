using Microsoft.AspNetCore.Mvc;
using SalesOrderManager.Server.Services;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(
            IOrderService orderService,
            ILogger<OrderController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Order>> Get()
        {
            _logger.LogInformation("Get all orders");
            return await _orderService.Get();
        }

        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            _logger.LogInformation($"Get Order with id: {id}");
            return await _orderService.Get(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _logger.LogInformation($"Delete Order with id: {id}");
            await _orderService.Delete(id);
        }

        [HttpPut]
        public async Task Put([FromBody] Order order)
        {
            _logger.LogInformation($"Update Order with id: {order.Id}");
            await _orderService.Update(order);
        }

        [HttpPost]
        public async Task Add(Order order)
        {
            _logger.LogInformation("Add new order");
            await _orderService.Add(order);
        }
    }
}
