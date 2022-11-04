using AutoMapper;
using Human.Humanity;
using Species.Organisms;

namespace Human;

public class HumanApplicationAutoMapperProfile : Profile
{
    public HumanApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Humanity.Human, HumanDto>();
        CreateMap<OrganismWithLineage<Humanity.Human>, OrganismWithLineageDto<HumanDto>>();
    }
    
}
