using Volo.Abp.Modularity;

namespace Abp.FamilyTree;

[DependsOn(
    typeof(FamilyTreeApplicationModule),
    typeof(FamilyTreeDomainTestModule)
    )]
public class FamilyTreeApplicationTestModule : AbpModule
{

}
