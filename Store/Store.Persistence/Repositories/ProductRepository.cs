using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class ProductRepository :GenericRepository<Product>, IProductRepository
    {
        private readonly StoreDbContext _context;

        public ProductRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
