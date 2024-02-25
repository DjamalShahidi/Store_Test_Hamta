using Store.Domain.Common;

namespace Store.Domain
{
    public class Feature : BaseDomainEntity
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public FeatureValueType Type { get; set; }

        public List<CategoryFeature> CategoryFeatures { get; set; }

        public List<ProductFeature> ProductFeatures { get; set; }


    }

    public enum FeatureValueType
    {
        Number=1,
        Boolean=2,
        String=3,
    }
}
