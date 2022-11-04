using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Species.EntityFrameworkCore;

[ConnectionStringName(SpeciesDbProperties.ConnectionStringName)]
public class SpeciesDbContext : AbpDbContext<SpeciesDbContext>, ISpeciesDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public SpeciesDbContext(DbContextOptions<SpeciesDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSpecies();
    }
}
