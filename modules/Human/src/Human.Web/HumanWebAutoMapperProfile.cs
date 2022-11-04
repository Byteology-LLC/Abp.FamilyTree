using AutoMapper;
using Human.Humanity;

namespace Human.Web;

public class HumanWebAutoMapperProfile : Profile
{
    public HumanWebAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<HumanDto, HumanCreateDto>();
        CreateMap<HumanDto, HumanUpdateDto>();
    }
}
