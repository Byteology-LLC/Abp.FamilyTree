using Species.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Species;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(SpeciesEntityFrameworkCoreTestModule)
    )]
public class SpeciesDomainTestModule : AbpModule
{

}
