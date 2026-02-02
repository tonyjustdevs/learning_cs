namespace TPNS.TPSharedLibNet2;


public class Person
{
    #region 1_Fields: Data
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

    #region 2_Constructors: methods run when 'new' keyword used
    public Person()
    {
        Name = "(Unknown)";
        Instantiated = DateTime.Now;
    }
    #endregion

    #region 3_Methods: Type to do things

    public void WriteOriginToConsole() => WriteLine($"{Name} is from {HomePlanet} [writeline]");
    public string GetOriginText() => $"{Name} is from {HomePlanet} [string]";
    
    public void ParamsParameter(string text, params int[] nums)
    {
        int total = 0;
        foreach (int num in nums)
        {
            total += num;
        }
        WriteLine("{0}: {1}",text,total);
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }
    
    //public UnnamedParameters GetFruitUnnamedAliasedTuple()
    //{
    //    return ("Apples", 5);
    //}


    public (string, int, decimal) GetUnnamedFruitV2()
    {
        return ("Apples", 5, 6.99m);
    }

    //public FruitQtyPriceAliasedTuple GetUnnamedFruitV2AliasedTuple()
    //{
    //    return ("Apples", 5, 6.99m);
    //}


    public (string fruit, int quantity) GetFruitNamedTuples()
    {
        return ("Apple", 5);
    }
    //public FruitAliasedTuples GetFruitNamedTuplesAlisedTuples()
    //{
    //    return ("Apple", 5);
    //}
    #endregion
}
