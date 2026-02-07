namespace TPNS.TPSharedLibNet2;

public partial class Person
{
    public string? Name;
    public DateTimeOffset Dob;
    public EnumSports? SportsFav;
    public EnumByteSports? SportLiked;
    public List<Person> Children = new();
    public const string Species = "Homo Sapien";
    public static readonly string HomePlanet = "Earth";

    #region Indexer: use array syntax on a Person instance
    public Person this[int index]
    {
        get { return this.Children[index]; }
        set { this.Children[index] = value; }
    }

    public Person this[string kiddo_name]
    {
        get 
        {
            return Children.Find(p => p.Name == kiddo_name); 
        }
    }
    #endregion

    #region Deconstruct
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Dob;
    }
    #endregion
}
