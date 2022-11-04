using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Human;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(HumanDomainSharedModule)
)]
public class HumanDomainModule : AbpModule
{

}
