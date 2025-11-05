using System.Runtime.CompilerServices;

namespace TP.SharedLibraries;

public partial class Person
{

    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset DOB {get;set;}
    public List<Person> Children {get;set;} = new();
    public List<Person> Spouses { get; set; } = new();
    #endregion
    public bool isMarried => Spouses.Count > 0;
    public int SpousesCount => Spouses.Count;
    public bool isMarried2 { get{ return Spouses.Count > 0; } }

    #region InstanceMethods
    public void WriteToConsole() => Console.WriteLine(
        $"'{Name}' " +
        $"was born a '{DOB:dddd}' "+
        $"& has '{SpousesCount}' spouse(s).' ");

    public void WriteKidsToConsole() 
    {
        string kids_term = Children.Count() == 1 ? "kid" : "kiddos";
        Console.WriteLine($"'{Name}' has {Children.Count()} {kids_term}.'");
    }
    #endregion

    #region StaticMethods
    public static void Marry(Person p1, Person p2)
    {
        Console.WriteLine("A Marry() ceremony is happening...");
        // 1. raise exception if null
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        // 2. check if p1 & partner already married
        if (p1.Spouses.Contains(p2) | p2.Spouses.Contains(p1))
        {
            Console.WriteLine("{0} & {1} are alreday hitched!", p1, p2);
        }
        else
        {
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }
    }
    public void Marry(Person partner)    // instance method
    {
        Marry(this, partner);
    }
    
    #endregion

    #region Marriage
    static public void HitchTwoPersons(Person p1, Person p2)    // static method
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (p1.Spouses.Contains(p2) | p2.Spouses.Contains(p1))
        {
            Console.WriteLine("already hitched them!");
        }
        else
        {
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }
    }
    #endregion

    #region MakeBabies
    public static void MakeBabies(Person p1, Person p2)
    {
        Console.WriteLine("MakeBabies() attempted...");
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (!p1.Spouses.Contains(p2) & !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException($"'{p1.Name}' & '{p2.Name}' must be MARRIED before making babies!");
            // [test-1] make 2 persons and make babies ---> [exp] error!
        }
        else
        {
            Console.WriteLine("babies made");
            Person bb = new() { Name = "bb1_p1p2", DOB = DateTimeOffset.Now };
            p1.Children.Add(bb);
            p2.Children.Add(bb);
        }
    }
    #endregion

    #region Operators
    public static bool operator +(Person p1, Person p2)
    {
        Console.WriteLine("'+' Operator -> Marry() run....");
        Marry(p1, p2); //[test-2] use + operator to perform marriage ceremony
        return true;
    }
    #endregion
    
    public static bool operator *(Person p1, Person p2)
    {
        Console.WriteLine("'*' Operator -> MakeBabies() run....");
        MakeBabies(p1, p2);
        return true;
    }
}
