using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Alien;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AlienDomainSharedModule)
)]
public class AlienDomainModule : AbpModule
{

}
