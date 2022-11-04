using Human.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Human;

public abstract class HumanController : AbpControllerBase
{
    protected HumanController()
    {
        LocalizationResource = typeof(HumanResource);
    }
}
