using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Alien;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AlienHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AlienConsoleApiClientModule : AbpModule
{

}
