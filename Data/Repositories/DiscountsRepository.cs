using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class DiscountsRepository:GenericRepository<Discount>,IDiscountsRepository
    {
        private readonly ApplicationDbContext _context;

        public DiscountsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
