using Abp.FamilyTree.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.FamilyTree.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FamilyTreePageModel : AbpPageModel
{
    protected FamilyTreePageModel()
    {
        LocalizationResourceType = typeof(FamilyTreeResource);
    }
}
