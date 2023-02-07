using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Repositories
{
    public class WindowRepository : GenericRepository<Window>, IWindowRepository
    {
        public WindowRepository(SalesOrderContext context) : base(context)
        {
        }
    }
}
