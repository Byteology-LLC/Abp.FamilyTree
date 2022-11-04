using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Alien;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AlienInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AlienInstallerModule>();
        });
    }
}
