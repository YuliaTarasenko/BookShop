using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class SubjectsRepository:GenericRepository<Subject>,ISubjectsRepository
    {
        private readonly ApplicationDbContext _context;

        public SubjectsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
