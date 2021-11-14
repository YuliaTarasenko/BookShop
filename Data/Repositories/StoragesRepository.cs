using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class StoragesRepository:GenericRepository<Storage>,IStoragesRepository
    {
        private readonly ApplicationDbContext _context;

        public StoragesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
