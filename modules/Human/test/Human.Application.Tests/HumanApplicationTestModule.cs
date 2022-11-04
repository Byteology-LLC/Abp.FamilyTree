using Volo.Abp.Modularity;

namespace Human;

[DependsOn(
    typeof(HumanApplicationModule),
    typeof(HumanDomainTestModule)
    )]
public class HumanApplicationTestModule : AbpModule
{

}
