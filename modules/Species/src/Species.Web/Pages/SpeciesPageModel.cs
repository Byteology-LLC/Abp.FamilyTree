using Species.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Species.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SpeciesPageModel : AbpPageModel
{
    protected SpeciesPageModel()
    {
        LocalizationResourceType = typeof(SpeciesResource);
        ObjectMapperContext = typeof(SpeciesWebModule);
    }
}
