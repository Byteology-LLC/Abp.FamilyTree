using Alien.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Alien.Permissions;

public class AlienPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AlienPermissions.GroupName, L("Permission:Alien"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AlienResource>(name);
    }
}
