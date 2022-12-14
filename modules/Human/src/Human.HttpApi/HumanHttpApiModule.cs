using Localization.Resources.AbpUi;
using Human.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Human;

[DependsOn(
    typeof(HumanApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class HumanHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(HumanHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<HumanResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
