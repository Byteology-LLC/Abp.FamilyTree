using Volo.Abp.Reflection;

namespace Alien.Permissions;

public class AlienPermissions
{
    public const string GroupName = "Alien";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AlienPermissions));
    }
}
