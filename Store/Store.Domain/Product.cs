using Store.Domain.Common;

namespace Store.Domain
{
    public class Product : BaseDomainEntity
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductFeature> ProductFeatures { get; set; }

    }

}
