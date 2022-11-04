using Human.Humanity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Human.EntityFrameworkCore;

[ConnectionStringName(HumanDbProperties.ConnectionStringName)]
public interface IHumanDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Humanity.Human> Humanity { get; set; }
}
