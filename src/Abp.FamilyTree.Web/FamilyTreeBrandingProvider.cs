using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.FamilyTree.Web;

[Dependency(ReplaceServices = true)]
public class FamilyTreeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FamilyTree";
}
