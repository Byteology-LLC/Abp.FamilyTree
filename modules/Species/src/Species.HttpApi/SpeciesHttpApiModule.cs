using Localization.Resources.AbpUi;
using Species.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Species;

[DependsOn(
    typeof(SpeciesApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SpeciesHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SpeciesHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SpeciesResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
