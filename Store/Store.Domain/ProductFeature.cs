using Store.Domain.Common;

namespace Store.Domain
{
    public class ProductFeature : BaseDomainEntity
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int AttributeId { get; set; }

        public Feature Feature { get; set; }
    }
}
