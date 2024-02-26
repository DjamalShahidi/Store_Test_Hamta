using AutoMapper;
using Store.Application.DTOs.Account;
using Store.Application.DTOs.Category;
using Store.Application.DTOs.Feature;
using Store.Application.DTOs.Product;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Domain;

namespace Store.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddFeatureDto, Feature>().ForMember(dest => dest.Type, opt => opt.MapFrom(src => MapValueType(src.Value))).ReverseMap();
            CreateMap<GetFeatureDto, Feature>().ReverseMap();
            CreateMap<AddCategoryDto, Category>().ReverseMap();
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<GetCategoryDto, Category>().ReverseMap();
            CreateMap<GetProductDto, Product>().ReverseMap();
            CreateMap<UserDTO, ApplicationUser>().ReverseMap();
            CreateMap<LoginRequestDTO, ApplicationUser>().ReverseMap();
            CreateMap<LoginResponseDTO, ApplicationUser>().ReverseMap();
            CreateMap<RegisterationRequestDTO, ApplicationUser>().ReverseMap();




        }

        private FeatureValueType MapValueType(object value)
        {
            var stValue= value.ToString();

            if (int.TryParse(stValue, out _))
            {
                return FeatureValueType.Number;
            }
           else if (bool.TryParse(stValue, out _))
            {
                return FeatureValueType.Boolean;
            }
            else
            {
                return FeatureValueType.String;
            }
        }
    }

   
}
