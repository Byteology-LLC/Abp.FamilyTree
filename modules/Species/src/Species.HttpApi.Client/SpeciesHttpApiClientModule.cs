using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Species;

[DependsOn(
    typeof(SpeciesApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SpeciesHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SpeciesApplicationContractsModule).Assembly,
            SpeciesRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SpeciesHttpApiClientModule>();
        });

    }
}
