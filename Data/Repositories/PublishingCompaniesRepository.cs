using BookShop.Models;

namespace BookShop.Data.Repositories
{
    public class PublishingCompaniesRepository : GenericRepository<PublishingCompany>, IPublishingCompaniesRepository
    {
        private readonly ApplicationDbContext _context;

        public PublishingCompaniesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
