using SalesOrderManager.Server.Repositories.Core;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Repositories
{
    public class SubElementRepository : GenericRepository<SubElement>, ISubElementRepository
    {
        public SubElementRepository(SalesOrderContext context) : base(context)
        {
        }
    }
}
