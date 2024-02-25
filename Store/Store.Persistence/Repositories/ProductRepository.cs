using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly StoreDbContext _context;

        public ProductRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<Product>> GetProductByCategoryIdAsync(int categoryId)
        {
            return await _context.Products.Include(a=>a.Category).Where(a => a.CategoryId == categoryId).ToListAsync();
        }

        public async Task<List<Product>> GetListAsyncWithInclude()
        {
            return await _context.Products.Include(a => a.Category).ToListAsync();
        }
    }
}
