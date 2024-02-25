using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class ProductFeaturesRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        private readonly StoreDbContext _context;

        public ProductFeaturesRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<ProductFeature>> GetListByProductIds(List<int> productIds)
        {
          return  await _context.ProductFeatures.Include(a=>a.Feature).Where(a => productIds.Contains(a.ProductId)).ToListAsync();
        }
    }
}
