using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Alien.EntityFrameworkCore;

[ConnectionStringName(AlienDbProperties.ConnectionStringName)]
public class AlienDbContext : AbpDbContext<AlienDbContext>, IAlienDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AlienDbContext(DbContextOptions<AlienDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAlien();
    }
}
