using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class AutorsRepository : GenericRepository<Autor>, IAutorsRepository
    {
        private readonly ApplicationDbContext _context;

        public AutorsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
