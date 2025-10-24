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
    public readonly string? Planet="earth"; // A readonly field can only take an assignment
                                    // in a constructor or at declaration.
    //public const DateTime SomeTime1 = DateTime.UtcNow; // wont work because not compile-time variable
    public readonly DateTime SomeTime2 = DateTime.UtcNow;
                    
    // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0191?f1url=%3FappId%3Droslyn%26k%3Dk(CS0191)



}
