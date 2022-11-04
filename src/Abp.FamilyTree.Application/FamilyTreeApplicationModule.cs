using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Species;
using Human;
using Alien;

namespace Abp.FamilyTree;

[DependsOn(
    typeof(FamilyTreeDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(FamilyTreeApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(SpeciesApplicationModule))]
    [DependsOn(typeof(HumanApplicationModule))]
    [DependsOn(typeof(AlienApplicationModule))]
    public class FamilyTreeApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<FamilyTreeApplicationModule>();
        });
    }
}
