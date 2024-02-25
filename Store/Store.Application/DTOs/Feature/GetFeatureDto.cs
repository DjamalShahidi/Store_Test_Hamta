using Store.Application.DTOs.Common;

namespace Store.Application.DTOs.Feature
{
    public record GetFeatureDto :BaseDto
    {
        public string Name { get; set; }

        public object Value { get; set; }
    }
}
