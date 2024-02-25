using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class ProductFeaturesRepository : GenericRepository<ProductFeature>, IProductFeaturesRepository
    {
        private readonly StoreDbContext _context;

        public ProductFeaturesRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
