using Store.Domain;

namespace Store.Application.Contracts.Persistence
{
    public interface IFeaturesRepository : IGenericRepository<Feature>
    {
        Task<bool> IsExistWithName(string Name);
        Task<List<Feature>> GetListByIdsAsync(List<int> ids);
    }
 
}
