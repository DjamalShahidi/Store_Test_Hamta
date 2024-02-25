using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts.Persistence;

namespace Store.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StoreDbContext _context;

        internal DbSet<T> dbSet;

        public GenericRepository(StoreDbContext context)
        {
            this._context = context;
            dbSet = context.Set<T>();

        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
