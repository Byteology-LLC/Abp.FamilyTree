using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Abp.FamilyTree.Data;
using Volo.Abp.DependencyInjection;

namespace Abp.FamilyTree.EntityFrameworkCore;

public class EntityFrameworkCoreFamilyTreeDbSchemaMigrator
    : IFamilyTreeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFamilyTreeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FamilyTreeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FamilyTreeDbContext>()
            .Database
            .MigrateAsync();
    }
}
