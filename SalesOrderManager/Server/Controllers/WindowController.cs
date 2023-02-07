using Microsoft.AspNetCore.Mvc;
using SalesOrderManager.Server.Services;

namespace SalesOrderManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowController : ControllerBase
    {
        private readonly IWindowService _windowService;

        public WindowController(IWindowService windowService)
        {
            _windowService = windowService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _windowService.Delete(id);
            return Ok();
        }
    }
}
