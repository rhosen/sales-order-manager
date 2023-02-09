using Microsoft.EntityFrameworkCore;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SalesOrderContext context) : base(context)
        {
        }

        public async Task<Order> GetOrder(int orderId)
        {
            return await _context.Orders
                .Include(o => o.Windows)
                .ThenInclude(w => w.SubElements)
                .FirstOrDefaultAsync(x => x.Id == orderId);
        }
    }
}
