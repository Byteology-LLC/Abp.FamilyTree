using Abp.FamilyTree.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.FamilyTree.Permissions;

public class FamilyTreePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FamilyTreePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FamilyTreePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FamilyTreeResource>(name);
    }
}
