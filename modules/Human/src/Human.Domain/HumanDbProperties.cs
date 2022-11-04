namespace Human;

public static class HumanDbProperties
{
    public static string DbTablePrefix { get; set; } = "Human";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Human";
}
