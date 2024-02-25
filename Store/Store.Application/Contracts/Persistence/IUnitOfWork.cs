namespace Store.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }

        IFeaturesRepository FeaturesRepository { get; }

        IProductFeaturesRepository ProductFeaturesRepository { get; }

        IProductRepository ProductRepository { get; }

        Task Save(CancellationToken cancellationToken);
    }
}
