namespace Species;

public static class SpeciesDbProperties
{
    public static string DbTablePrefix { get; set; } = "Species";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Species";
}
