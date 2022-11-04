using Volo.Abp.Modularity;

namespace Alien;

[DependsOn(
    typeof(AlienApplicationModule),
    typeof(AlienDomainTestModule)
    )]
public class AlienApplicationTestModule : AbpModule
{

}
