using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class CategoryFeatureRepository : GenericRepository<CategoryFeature>, ICategoryFeatureRepository
    {
        private readonly StoreDbContext _context;

        public CategoryFeatureRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
