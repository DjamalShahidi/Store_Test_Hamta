using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{

    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly StoreDbContext _context;

        public CategoryRepository(StoreDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
