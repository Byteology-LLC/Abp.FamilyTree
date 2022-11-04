namespace Alien;

public static class AlienDbProperties
{
    public static string DbTablePrefix { get; set; } = "Alien";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Alien";
}
