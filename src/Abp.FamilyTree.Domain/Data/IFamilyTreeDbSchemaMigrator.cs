using System.Threading.Tasks;

namespace Abp.FamilyTree.Data;

public interface IFamilyTreeDbSchemaMigrator
{
    Task MigrateAsync();
}
