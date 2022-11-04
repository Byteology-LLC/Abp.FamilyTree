using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Species;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class SpeciesInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SpeciesInstallerModule>();
        });
    }
}
