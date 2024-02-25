using Store.Application.DTOs.Common;

namespace Store.Application.DTOs.Category
{
    record class GetCategoryDto :BaseDto
    {
        public string Title { get; set; }

        public List<GetCategoryFeatureDto> Features { get; set; }=new List<GetCategoryFeatureDto>();
    }

    record class GetCategoryFeatureDto : BaseDto
    {
        public string Name { get; set; }

        public object Value { get; set; }
    }
}
