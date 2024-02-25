namespace Store.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
    }
}
