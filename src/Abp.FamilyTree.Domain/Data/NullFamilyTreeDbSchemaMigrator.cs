using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.FamilyTree.Data;

/* This is used if database provider does't define
 * IFamilyTreeDbSchemaMigrator implementation.
 */
public class NullFamilyTreeDbSchemaMigrator : IFamilyTreeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
