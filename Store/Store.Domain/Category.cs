using Store.Domain.Common;

namespace Store.Domain
{
    public class Category : BaseDomainEntity
    {
        public string Title { get; set; }

        public List<Product> Products { get; set; }

        public List<CategoryFeature> CategoryFeatures { get; set; }

    }
}
