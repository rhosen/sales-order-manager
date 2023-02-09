using Microsoft.AspNetCore.Mvc;
using SalesOrderManager.Server.Services;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubElementController : ControllerBase
    {
        private readonly ISubElementService _subElementService;
        private readonly ILogger<SubElementController> _logger;

        public SubElementController(
            ISubElementService subElementService,
            ILogger<SubElementController> logger)
        {
            _subElementService = subElementService;
            _logger = logger;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _logger.LogInformation($"Delete subelement with id: {id}");
            await _subElementService.Delete(id);
        }

        [HttpPut]
        public async Task Put([FromBody] SubElement subelement)
        {
            _logger.LogInformation($"Update subelement with id: {subelement.Id}");
            await _subElementService.Update(subelement);
        }

        [HttpPost]
        public async Task Add(SubElement subelement)
        {
            _logger.LogInformation($"Add new subelement");
            await _subElementService.Add(subelement);
        }
    }
}
