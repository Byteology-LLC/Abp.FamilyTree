using Human.Localization;
using Volo.Abp.Application.Services;

namespace Human;

public abstract class HumanAppService : ApplicationService
{
    protected HumanAppService()
    {
        LocalizationResource = typeof(HumanResource);
        ObjectMapperContext = typeof(HumanApplicationModule);
    }
}
