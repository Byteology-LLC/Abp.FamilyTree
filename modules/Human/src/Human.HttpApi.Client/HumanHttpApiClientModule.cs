using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Human;

[DependsOn(
    typeof(HumanApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class HumanHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(HumanApplicationContractsModule).Assembly,
            HumanRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<HumanHttpApiClientModule>();
        });

    }
}
