using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Human;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class HumanInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<HumanInstallerModule>();
        });
    }
}
