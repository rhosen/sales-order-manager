using Microsoft.AspNetCore.Mvc;
using SalesOrderManager.Server.Services;

namespace SalesOrderManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubElementController : ControllerBase
    {
        private readonly ISubElementService _subElementService;

        public SubElementController(ISubElementService subElementService)
        {
            _subElementService = subElementService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _subElementService.Delete(id);
            return Ok();
        }
    }
}
