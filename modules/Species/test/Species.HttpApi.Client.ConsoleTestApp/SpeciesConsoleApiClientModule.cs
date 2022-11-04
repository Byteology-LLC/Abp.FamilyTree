using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Species;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SpeciesHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SpeciesConsoleApiClientModule : AbpModule
{

}
