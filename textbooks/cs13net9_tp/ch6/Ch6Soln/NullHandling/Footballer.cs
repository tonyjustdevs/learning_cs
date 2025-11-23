
namespace NullHandling;

public class Footballer
{
    public string FirstName;
    //public string LastName = string.Empty;
    public string LastName = "<LastName>";
    public double Value;
    public string? Club;

    public Footballer() {
        //FirstName = string.Empty;
        FirstName = "<FirstName>";
    }

    public Footballer(string club): this()
    {
        Club = club;
    }

    public Footballer(double value) : this()
    {
        Value = value;
    }

    public Footballer(string club, double value) : this()
    {
        Club = club;
        Value = value;
    }
    public Footballer(string club, double value, string fname) : this()
    {
        Club = club;
        Value = value;
        FirstName = fname;
    }

}
// 1.  add parameterless constructor
// 2.  add 1-param constructor
