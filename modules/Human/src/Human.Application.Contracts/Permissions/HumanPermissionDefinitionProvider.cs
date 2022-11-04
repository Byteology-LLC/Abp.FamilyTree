using Human.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Human.Permissions;

public class HumanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HumanPermissions.GroupName, L("Permission:Human"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HumanResource>(name);
    }
}
