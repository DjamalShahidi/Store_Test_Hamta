using Store.Domain.Common;

namespace Store.Domain
{
    public class ProductCategory : BaseDomainEntity
    {
        public string Title { get; set; }

        public List<Product> Products { get; set; }


    }
}
