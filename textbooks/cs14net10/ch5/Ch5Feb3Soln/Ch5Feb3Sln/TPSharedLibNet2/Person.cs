namespace TPNS.TPSharedLibNet2;

public class Person
{
    #region Fields
    public string? Name;
    public DateTimeOffset Born;
    public EnumGames? GameFavourite;
    public EnumByteGames? GameLiked;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime? Instantiated;
    #endregion


    #region Constructors
    public Person() {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string name)
    {
        Name = name;
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Methods
    // create method that uses 'in', 'out' and 'ref' parameter types

    //void SomeInMethod(in some_in_param)
    //{
    //    WriteLine(some_in_param);
    //}
    #endregion
    #region Deconstruct

    //public void Deconstruct(out string? out_name)   // deconstruct_1_fld: name only
    //{
    //    out_name = Name; // doesnt work with single desconstrcution
    //}


    public void Deconstruct(out string? out_name, out DateTimeOffset dob)   // deconstruct_1_fld: name only
    {
        out_name = Name;
        dob = Born;
    }
    
    // deconstruct_1_fld: name only
    #endregion



}
