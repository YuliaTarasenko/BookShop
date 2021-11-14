using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class OrdersRepository:GenericRepository<Order>,IOrdersRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdersRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
