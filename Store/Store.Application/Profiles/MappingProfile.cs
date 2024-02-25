using AutoMapper;
using Store.Application.DTOs.Feature;
using Store.Domain;

namespace Store.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddFeatureDto, Feature>().ForMember(dest => dest.Type, opt => opt.MapFrom(src => MapValueType(src.Value))).ReverseMap();
            CreateMap<GetFeatureDto, Feature>().ReverseMap();

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
