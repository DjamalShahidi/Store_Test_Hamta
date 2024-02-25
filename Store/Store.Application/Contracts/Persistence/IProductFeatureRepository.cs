using Store.Domain;

namespace Store.Application.Contracts.Persistence
{
    public interface IProductFeatureRepository : IGenericRepository<ProductFeature>
    {
        Task<List<ProductFeature>> GetListByProductIds(List<int> productIds);
    }
}
