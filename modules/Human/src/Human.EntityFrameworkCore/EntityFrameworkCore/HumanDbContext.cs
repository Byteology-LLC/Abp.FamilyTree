using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Human.EntityFrameworkCore;

[ConnectionStringName(HumanDbProperties.ConnectionStringName)]
public class HumanDbContext : AbpDbContext<HumanDbContext>, IHumanDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Humanity.Human> Humanity { get; set; }

    public HumanDbContext(DbContextOptions<HumanDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureHuman();
    }
}
