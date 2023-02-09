using SalesOrderManager.Server.Repositories;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public class SubElementService : ISubElementService
    {
        private readonly ISubElementRepository _subElementRepository;

        public SubElementService(ISubElementRepository subElementRepository)
        {
            _subElementRepository = subElementRepository;
        }

        public async Task Add(SubElement subelement)
        {
            await _subElementRepository.Add(subelement);
        }

        public async Task Delete(int id)
        {
            await _subElementRepository.Delete(id);
        }

        public async Task Update(SubElement subelement)
        {
            await _subElementRepository.Update(subelement);
        }
    }
}
