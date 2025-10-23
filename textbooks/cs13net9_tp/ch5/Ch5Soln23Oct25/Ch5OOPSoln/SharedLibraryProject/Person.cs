using TP.SharedNamespace;

public class Person
{
    public string? Name { get; set; }
    public DateTime? DOB { get; set; }
    public CountryEnum? Country { get; set; }
    public CountryEnumByte? CountryBucketList { get; set; }

    public List<Person> Children = new(); // create object and Children (a pointer to -> List<P> object in memory)
}
