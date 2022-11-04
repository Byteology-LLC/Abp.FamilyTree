using Localization.Resources.AbpUi;
using Abp.FamilyTree.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Species;
using Human;
using Alien;

namespace Abp.FamilyTree;

[DependsOn(
    typeof(FamilyTreeApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
[DependsOn(typeof(SpeciesHttpApiModule))]
    [DependsOn(typeof(HumanHttpApiModule))]
    [DependsOn(typeof(AlienHttpApiModule))]
    public class FamilyTreeHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FamilyTreeResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
