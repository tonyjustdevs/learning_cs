namespace TPNS.TPSharedLibNet2;

public class Person
{
    #region Fields: Data
    public string? Name;
    public DateTimeOffset Born;
    public EnumSports SportsFavourite;
    public EnumByteSports SportsLiked;
    public List<Person> Children = new();
    public readonly string HomePlanet = "Earth";
    public const string? Species ="Homo Sapiens"; // static (redundant) implied from `const`
    public static readonly double EulersNo2 = Math.E;
    public readonly DateTime? Instantiated;
    #endregion

    #region Constructors: methods run when 'new' keyword used
    // 1. Fields initialisation via Constructor
    public Person()
    {
        Name = "(Unknown)";
        Instantiated = DateTime.Now;
    }
    #endregion
}
