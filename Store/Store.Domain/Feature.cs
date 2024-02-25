namespace Store.Domain
{
    public class Feature
    {
        public string Name { get; set; }

        public Object Value { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
