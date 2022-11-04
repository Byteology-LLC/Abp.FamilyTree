using Species.Localization;
using Volo.Abp.Application.Services;

namespace Species;

public abstract class SpeciesAppService : ApplicationService
{
    protected SpeciesAppService()
    {
        LocalizationResource = typeof(SpeciesResource);
        ObjectMapperContext = typeof(SpeciesApplicationModule);
    }
}
