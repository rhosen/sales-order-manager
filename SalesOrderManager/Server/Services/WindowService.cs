using SalesOrderManager.Server.Repositories;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public class WindowService : IWindowService
    {
        private readonly IWindowRepository _windowRepository;

        public WindowService(IWindowRepository windowRepository)
        {
            _windowRepository = windowRepository;
        }

        public async Task Add(Window window)
        {
            await _windowRepository.Add(window);
        }

        public async Task Delete(int id)
        {
            await _windowRepository.Delete(id);
        }

        public async Task<List<Window>> Get()
        {
            return await _windowRepository.GetAll();
        }
    }
}
