using System;
using System.Collections.Generic;
using System.Text;
using Abp.FamilyTree.Localization;
using Volo.Abp.Application.Services;

namespace Abp.FamilyTree;

/* Inherit your application services from this class.
 */
public abstract class FamilyTreeAppService : ApplicationService
{
    protected FamilyTreeAppService()
    {
        LocalizationResource = typeof(FamilyTreeResource);
    }
}
