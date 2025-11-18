
namespace TP.SharedLibraries;

public class MyString : IComparable<MyString?>
{
    private string? _Value;
    public string ? Value { get {  return _Value; } }
    // primitivte constructor
    public MyString(string? value)
    {
        _Value = value;
    }
    public int CompareTo(MyString? other)
    {
        Console.WriteLine("Doing Custom CompareTo()...");
        if (other is null) return -1;
        if (this.Value is null) return 1;
        
        return this.Value.CompareTo(other.Value);
    }
}
