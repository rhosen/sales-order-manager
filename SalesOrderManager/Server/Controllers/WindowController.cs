using Microsoft.AspNetCore.Mvc;
using SalesOrderManager.Server.Services;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowController : ControllerBase
    {
        private readonly IWindowService _windowService;
        private readonly ILogger<WindowController> _logger;

        public WindowController(
            IWindowService windowService,
            ILogger<WindowController> logger)
        {
            _windowService = windowService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Window>> Get()
        {
            _logger.LogInformation("Get all windows");
            return await _windowService.Get();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _logger.LogInformation($"Delete window with id: {id}");
            await _windowService.Delete(id);
        }

        [HttpPost]
        public async Task<Window> Add(Window window)
        {
            _logger.LogInformation($"Add new window");
            return await _windowService.Add(window);
        }
    }
}
