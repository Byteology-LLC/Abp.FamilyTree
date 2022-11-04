using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Human;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HumanHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class HumanConsoleApiClientModule : AbpModule
{

}
