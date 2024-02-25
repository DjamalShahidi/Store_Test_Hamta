using Store.Domain.Common;

namespace Store.Domain
{
    public class ProductAttribute : BaseDomainEntity
    {
        public string Name { get; set; }

        public Object Value { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
