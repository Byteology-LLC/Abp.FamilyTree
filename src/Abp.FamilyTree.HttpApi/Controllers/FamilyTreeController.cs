using Abp.FamilyTree.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.FamilyTree.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FamilyTreeController : AbpControllerBase
{
    protected FamilyTreeController()
    {
        LocalizationResource = typeof(FamilyTreeResource);
    }
}
