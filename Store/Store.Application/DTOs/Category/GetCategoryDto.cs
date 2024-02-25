using Store.Application.DTOs.Common;

namespace Store.Application.DTOs.Category
{
    record class GetCategoryDto :BaseDto
    {
        public string Title { get; set; }

    }
}
