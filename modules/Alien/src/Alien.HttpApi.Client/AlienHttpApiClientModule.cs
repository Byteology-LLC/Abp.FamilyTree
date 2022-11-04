using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Alien;

[DependsOn(
    typeof(AlienApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AlienHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AlienApplicationContractsModule).Assembly,
            AlienRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AlienHttpApiClientModule>();
        });

    }
}
