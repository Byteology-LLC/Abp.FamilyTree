using Alien.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Alien;

public abstract class AlienController : AbpControllerBase
{
    protected AlienController()
    {
        LocalizationResource = typeof(AlienResource);
    }
}
