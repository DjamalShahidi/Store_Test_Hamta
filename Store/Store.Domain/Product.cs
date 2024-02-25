using Store.Domain.Common;

namespace Store.Domain
{
    public class Product : BaseDomainEntity
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string ImgUrl { get; set; }

        public int ProductCategoryId { get; set; }

        public Category ProductCategory { get; set; }

        public List<ProductFeature> productFeatures { get; set; }

    }

}
