
using System.Runtime.CompilerServices;

partial class Program
{
    // testing this

    
}

public record PersonRecord3(string? fname, string? lname)
{
    PersonRecord3() : this(null, null) { }
}

public class PersonClass1(string fname, string lname)
{
    public string Fname = fname;
    public string Lname = lname;
    PersonClass1() : this("old", "mate") 
    {
        WriteLine($"Parameterless PersonClass1() created: '{this}'");

    }
}
public interface IMoreImportant<T>
{
    T IsMoreImportant(T a, T b);
}

public class EvaluateImportance : IMoreImportant<int>, IMoreImportant<string>
{
    public int IsMoreImportant(int a, int b)
    {
        return a>=b ? a : b;
    }

    public string IsMoreImportant(string a, string b)
    {
        return a.Length >= b.Length ? a : b;

    }
}