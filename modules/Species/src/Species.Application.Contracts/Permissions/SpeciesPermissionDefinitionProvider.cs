using Species.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Species.Permissions;

public class SpeciesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SpeciesPermissions.GroupName, L("Permission:Species"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SpeciesResource>(name);
    }
}
