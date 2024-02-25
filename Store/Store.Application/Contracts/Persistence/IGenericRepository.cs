namespace Store.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task<List<T>> AddListAsync(List<T> entities);

        Task<List<T>> GetListAsync();
        Task<bool> IsExist(int id);

    }
}
