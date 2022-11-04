using Alien.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Alien.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AlienPageModel : AbpPageModel
{
    protected AlienPageModel()
    {
        LocalizationResourceType = typeof(AlienResource);
        ObjectMapperContext = typeof(AlienWebModule);
    }
}
