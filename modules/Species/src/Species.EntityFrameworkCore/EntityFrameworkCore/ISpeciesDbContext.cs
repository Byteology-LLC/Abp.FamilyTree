using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Species.EntityFrameworkCore;

[ConnectionStringName(SpeciesDbProperties.ConnectionStringName)]
public interface ISpeciesDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
