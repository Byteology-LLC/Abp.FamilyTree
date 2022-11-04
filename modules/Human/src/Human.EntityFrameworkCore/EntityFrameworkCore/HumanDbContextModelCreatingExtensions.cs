using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Human.EntityFrameworkCore;

public static class HumanDbContextModelCreatingExtensions
{
    public static void ConfigureHuman(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(HumanDbProperties.DbTablePrefix + "Questions", HumanDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Humanity.Human>(b =>
        {
            b.ToTable(HumanDbProperties.DbTablePrefix + "Humanity", HumanDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
