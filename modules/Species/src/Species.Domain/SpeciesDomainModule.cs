using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Species;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SpeciesDomainSharedModule)
)]
public class SpeciesDomainModule : AbpModule
{

}
