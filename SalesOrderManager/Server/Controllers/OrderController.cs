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

        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            var order = await _orderService.Get(id);
            return order;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Order order)
        {
            await _orderService.Update(order);
        }
    }
}
