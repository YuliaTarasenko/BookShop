using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class BooksRepository : GenericRepository<Book>, IBooksRepository
    {
        private readonly ApplicationDbContext _context;

        public BooksRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
    }
}
