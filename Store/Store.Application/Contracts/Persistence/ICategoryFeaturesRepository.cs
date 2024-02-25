using Store.Domain;

namespace Store.Application.Contracts.Persistence
{
    public interface ICategoryFeatureRepository : IGenericRepository<CategoryFeature>
    {
        Task<List<CategoryFeature>> GetListByCategoryIds(List<int> categoryIds);

    }
}
