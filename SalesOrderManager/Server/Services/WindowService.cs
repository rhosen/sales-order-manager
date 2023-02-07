using SalesOrderManager.Server.Repositories;

namespace SalesOrderManager.Server.Services
{
    public class WindowService : IWindowService
    {
        private readonly IWindowRepository _windowRepository;
        private readonly ISubElementRepository _subElementRepository;

        public WindowService(IWindowRepository windowRepository,
                             ISubElementRepository subElementRepository)
        {
            _windowRepository = windowRepository;
            _subElementRepository = subElementRepository;
        }
        public async Task Delete(int id)
        {
            try
            {
                await _windowRepository.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
