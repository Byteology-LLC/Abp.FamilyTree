using Abp.FamilyTree.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.FamilyTree.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FamilyTreeEntityFrameworkCoreModule),
    typeof(FamilyTreeApplicationContractsModule)
    )]
public class FamilyTreeDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
