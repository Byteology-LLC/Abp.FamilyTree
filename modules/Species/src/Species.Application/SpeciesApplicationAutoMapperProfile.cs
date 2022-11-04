using AutoMapper;
using Species.Organisms;

namespace Species;

public class SpeciesApplicationAutoMapperProfile : Profile
{
    public SpeciesApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Organism, OrganismDto>();
        CreateMap<OrganismWithLineage<Organism>, OrganismWithLineageDto<OrganismDto>>();
    }
}
