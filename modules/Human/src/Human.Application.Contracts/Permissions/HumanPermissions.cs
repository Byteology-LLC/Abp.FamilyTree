using Volo.Abp.Reflection;

namespace Human.Permissions;

public class HumanPermissions
{
    public const string GroupName = "Human";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(HumanPermissions));
    }
}
