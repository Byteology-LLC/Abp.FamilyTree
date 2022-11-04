using Volo.Abp.Settings;

namespace Abp.FamilyTree.Settings;

public class FamilyTreeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FamilyTreeSettings.MySetting1));
    }
}
