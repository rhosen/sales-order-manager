using Microsoft.AspNetCore.Http;
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

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await _orderService.Get();
        }

        [HttpGet("{orderId}")]
        public async Task<Order> Get(int orderId)
        {
            var order = await _orderService.Get(orderId);
            return order;
        }
    }
}
