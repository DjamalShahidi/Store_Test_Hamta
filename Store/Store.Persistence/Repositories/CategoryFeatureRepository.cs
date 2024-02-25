using Microsoft.EntityFrameworkCore;
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

        public async Task<List<CategoryFeature>> GetListByCategoryIds(List<int> categoryIds)
        {
          return  await _context.CategoryFeatures.Include(a=>a.Feature).Where(a => categoryIds.Contains(a.CategoryId)).ToListAsync();
        }
    }
}
