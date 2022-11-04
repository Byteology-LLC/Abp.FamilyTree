using Volo.Abp.Reflection;

namespace Species.Permissions;

public class SpeciesPermissions
{
    public const string GroupName = "Species";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SpeciesPermissions));
    }
}
