using Alien.Localization;
using Volo.Abp.Application.Services;

namespace Alien;

public abstract class AlienAppService : ApplicationService
{
    protected AlienAppService()
    {
        LocalizationResource = typeof(AlienResource);
        ObjectMapperContext = typeof(AlienApplicationModule);
    }
}
