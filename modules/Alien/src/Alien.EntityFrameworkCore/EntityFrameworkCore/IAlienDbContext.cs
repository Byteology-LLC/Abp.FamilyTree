using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Alien.EntityFrameworkCore;

[ConnectionStringName(AlienDbProperties.ConnectionStringName)]
public interface IAlienDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
