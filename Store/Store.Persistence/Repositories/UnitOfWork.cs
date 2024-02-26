using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using Store.Application.Contracts.Persistence;
using Store.Domain;

namespace Store.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _context;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IFeaturesRepository _featuresRepository;
        private ICategoryFeatureRepository _categoryFeatureRepository;
        private IProductFeatureRepository _productFeatureRepository;
        private IUserRepository _userRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public UnitOfWork(StoreDbContext context, 
                          UserManager<ApplicationUser> userManager=null,
                          RoleManager<IdentityRole> roleManager=null)
        {
            this._context = context;
            this._userManager = userManager;
            this._roleManager = roleManager;
        }

        public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_context);

        public IFeaturesRepository FeaturesRepository => _featuresRepository ??= new FeaturesRepository(_context);

        public ICategoryFeatureRepository CategoryFeatureRepository => _categoryFeatureRepository ??= new CategoryFeatureRepository(_context);

        public IProductFeatureRepository ProductFeatureRepository => _productFeatureRepository ??= new ProductFeaturesRepository(_context);

        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context, _userManager, _roleManager);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Database.BeginTransactionAsync(cancellationToken);
        }
    }
}
