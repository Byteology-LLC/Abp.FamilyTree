using Species.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Species;

public abstract class SpeciesController : AbpControllerBase
{
    protected SpeciesController()
    {
        LocalizationResource = typeof(SpeciesResource);
    }
}
