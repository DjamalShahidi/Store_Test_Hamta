namespace Store.Domain
{
    public class CategoryFeature
    {
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int FeatureId { get; set; }

        public Feature Feature { get; set; }
    }
}
