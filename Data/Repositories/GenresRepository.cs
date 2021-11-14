using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class GenresRepository : GenericRepository<Genre>, IGenresRepository
    {
        private readonly ApplicationDbContext _context;

        public GenresRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
