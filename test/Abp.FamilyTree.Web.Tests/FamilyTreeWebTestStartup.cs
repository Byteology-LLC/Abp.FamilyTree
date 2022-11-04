using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Abp.FamilyTree;

public class FamilyTreeWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<FamilyTreeWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
