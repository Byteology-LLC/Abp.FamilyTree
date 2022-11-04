using Human.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Human;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(HumanEntityFrameworkCoreTestModule)
    )]
public class HumanDomainTestModule : AbpModule
{

}
