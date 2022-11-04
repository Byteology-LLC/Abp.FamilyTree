using Human.Humanity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Human.EntityFrameworkCore;

[DependsOn(
    typeof(HumanDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class HumanEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<HumanDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddRepository<Humanity.Human, EfCoreHumanRepository>();
        });
    }
}
