using Abp.FamilyTree.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.FamilyTree;

[DependsOn(
    typeof(FamilyTreeEntityFrameworkCoreTestModule)
    )]
public class FamilyTreeDomainTestModule : AbpModule
{

}
