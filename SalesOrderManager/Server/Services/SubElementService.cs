using SalesOrderManager.Server.Repositories;

namespace SalesOrderManager.Server.Services
{
    public class SubElementService : ISubElementService
    {
        private readonly ISubElementRepository _subElementRepository;

        public SubElementService(ISubElementRepository subElementRepository)
        {
            _subElementRepository = subElementRepository;
        }

        public async Task Delete(int id)
        {
            await _subElementRepository.Delete(id);
        }
    }
}
