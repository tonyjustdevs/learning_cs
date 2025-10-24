using System.Globalization;
using System.Linq.Expressions;
using TP.SharedNamespace;

public class Person
{
    public string? Name { get; set; }
    public DateTime? DOB { get; set; }
    public CountryEnum? Country { get; set; }
    public CountryEnumByte? CountryBucketList { get; set; }
    public List<Person> Children = new(); // create object and Children (a pointer to -> List<P> object in memory)
    public const string Species = "homo erecxtus"; // must be avai at compile-time (not always best practice)
    public readonly string Planet ="earth"; // A readonly field can only take an assignment
    //public readonly string? Planet; // A readonly field can only take an assignment
    //public readonly string HomePlanet = "Earth";

    // in a constructor or at declaration.
    //public const DateTime SomeTime1 = DateTime.UtcNow; // wont work because not compile-time variable
    public readonly DateTime SomeTime2 = DateTime.UtcNow;
    // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0191?f1url=%3FappId%3Droslyn%26k%3Dk(CS0191)
    public const string Species2="homo saps";
    public readonly string? ClosestStar="the sun";
    public readonly DateTime Instantiated;
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

}
