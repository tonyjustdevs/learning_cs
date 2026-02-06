namespace TPNS.TPSharedLibNet2;

public partial class Person
{
    #region Fields
    public string? Name;
    public DateTimeOffset Born;
    // moved to PersonAutoGen.cs as a property
    // public EnumSports SportsFav;
    public List<Person> Children = new();
    public List<Person> Friends = new();
    public EnumByteSports SportsLiked;
    public EnumByteGames GamesLiked;
    public const string Species = "Homo Sapiens";       // compile-time 
    public readonly string HomePlanet = "Earth";        // run-time
    public DateTime Instantiated = DateTime.Now;
    #endregion

    #region Constructors
    public Person()
    {
        Name = "Unknown";
        Born = DateTime.UtcNow;
    }
    #endregion

    #region Methods
    public void GetOrigin()
    {
        WriteLine("{0} is from {1}.",Name,HomePlanet);
    }

    public void PrintSpecies()
    {
        WriteLine("{0} is the {1} species.", Name, Species);
    }
    #endregion



    #region Deconstructors
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out List<Person> kiddos)
    {
        name = Name;
        dob = Born;
        kiddos = Children;
    }
    #endregion

}
