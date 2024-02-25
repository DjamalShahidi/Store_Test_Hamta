using Store.Domain.Common;

namespace Store.Domain
{
    public class ProductFeature : BaseDomainEntity
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int FeatureId { get; set; }

        public Feature Feature { get; set; }
    }
}
