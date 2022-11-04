using Localization.Resources.AbpUi;
using Alien.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Alien;

[DependsOn(
    typeof(AlienApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AlienHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AlienHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AlienResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
