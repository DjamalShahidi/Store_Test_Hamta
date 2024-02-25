using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class FeaturesRepository : GenericRepository<Feature>, IFeaturesRepository
    {
        private readonly StoreDbContext _context;

        public FeaturesRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
