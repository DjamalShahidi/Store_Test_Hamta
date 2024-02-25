using Store.Application.Contracts.Persistence;

namespace Store.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _context;

        //private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IFeaturesRepository _featuresRepository;
        private ICategoryFeatureRepository _categoryFeatureRepository;

        //private IProductFeaturesRepository _productFeaturesRepository;


        public UnitOfWork(StoreDbContext context)
        {
            this._context = context;
        }

        //public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_context);

        public IFeaturesRepository FeaturesRepository => _featuresRepository ??= new FeaturesRepository(_context);

        public ICategoryFeatureRepository CategoryFeatureRepository => _categoryFeatureRepository ??= new CategoryFeatureRepository(_context);

        //public IProductFeaturesRepository ProductFeaturesRepository => _productFeaturesRepository ??= new ProductFeaturesRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
