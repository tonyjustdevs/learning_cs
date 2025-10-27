using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using TP.SharedNamespace;

public class Person
{
    public string? Name { get; set; }
    public DateTime? DOB { get; set; }
    public CountryEnum? Country { get; set; }
    public CountryEnumByte? CountryBucketList { get; set; }
    public List<Person> Children = new(); // create object and Children (a_bv pointer to -> List<P> object in memory)
    public const string Species = "homo erecxtus"; // must be avai at compile-time (not always best practice)
    public readonly string Planet = "earth"; // A readonly field can only take an assignment
    //public readonly string? Planet; // A readonly field can only take an assignment
    //public readonly string HomePlanet = "Earth";

    // in a_bv constructor or at declaration.
    //public const DateTime SomeTime1 = DateTime.UtcNow; // wont work because not compile-time variable
    public readonly DateTime SomeTime2 = DateTime.UtcNow;
    // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0191?f1url=%3FappId%3Droslyn%26k%3Dk(CS0191)
    public const string Species2 = "homo saps";
    public readonly string? ClosestStar = "the sun";
    public readonly DateTime Instantiated;
    public AngelsFlaggedBytes Angels;
    public Angel? FavouriteAngel;
    public List<Angel> AngelList = new();
    public Person() // default constructor;
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string name_param, string planet_param) // default constructor
    {
        Name = name_param;
        Planet = planet_param;
        Instantiated = DateTime.Now;
    }
    // 8.1  Name="Unknown"
    // 8.2  Instantiated =...;

    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} is born on {DOB:dddd}!");
    }

    public string GetHomeInformation()
    {
        return $"{Name} currenty lives in {Planet}.";
    }

    //string? x_ref = "I'm so xy";
    //static x_ref = "I'm so xy";
    //public const int some_var = 69;
    const int some_var = 69;
    public void PassingParams(ref int c_ref, out int d_out, int a_bv = 0, in int b_in = some_var)
    {
        _ = a_bv; // a: by-value
        d_out = 420;
        _ = d_out;

        Console.WriteLine($"abv:{a_bv}, bin:{b_in}, cref:{c_ref}, dout:{d_out}");
    }

    public void PassingParamsParam(string some_text, params int[] some_ints)
    {
        Console.Write($"{some_text}");
        int csum = 0;
        foreach (int v in some_ints)
        {
            csum += v;
            Console.WriteLine($"{v} added. csum = {csum}");
        }
        Console.Write($"final total: {csum}");
    }

    public void FunctionWithParamsKeyword(string datastructure_str_param, params int[] int_list_params)
    {
        Console.Write($"{datastructure_str_param}: ");

        int csum = 0;
        foreach (int item in int_list_params)
        {
            csum += item;
            Console.Write($"\nadding {item}, csum:{csum}");
        }
        Console.WriteLine($"\ntotal: {csum}\n");
    }

    public (string, int) getFruitTuple()
    {
        return ("mango", 420);
    }

    public (string FruitName, int FruitNo) getFruitNamedTuple()
    {
        return ("orange", 88);
    }

    public (int ID, string soccerplayer, long valuation) getMessi()
    {

        return (10, "messi", 1_000_000_000);
    }

    // Deconstructors: Break down this object into parts.
    public void Deconstruct(out string? nameTo, out DateTime? dobTo)
    {
        nameTo = Name;
        dobTo = DOB;
    }

    public (int, string) RandomRGBTupleReturner()
    {
        return (69, "red");
    }
}

    
