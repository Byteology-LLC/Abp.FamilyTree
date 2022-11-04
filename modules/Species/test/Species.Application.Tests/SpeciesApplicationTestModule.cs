using Volo.Abp.Modularity;

namespace Species;

[DependsOn(
    typeof(SpeciesApplicationModule),
    typeof(SpeciesDomainTestModule)
    )]
public class SpeciesApplicationTestModule : AbpModule
{

}
