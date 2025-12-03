
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP.SharedLibraries;

public struct DisplacementVector
{
    public int X { get; set; }
    public int Y { get; set; }
    public DisplacementVector(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static DisplacementVector operator+(DisplacementVector dv_1, DisplacementVector dv_2)
    {
        int new_x = dv_1.X + dv_2.X;
        int new_y = dv_1.Y + dv_2.Y;
        return new DisplacementVector(new_x, new_y);
    }
    
    public static bool operator==(DisplacementVector dv1, DisplacementVector dv2)
    {
        Console.WriteLine("running custom overriden equality '=='");
        return dv1.Equals(dv2);
    }
    public static bool operator !=(DisplacementVector dv1, DisplacementVector dv2)
    {
        Console.WriteLine("running custom overriden inequality '!='");
        return !dv1.Equals(dv2);
    }

}

// 1.  declared type: struct (instead of class.)
// 2.  add [two int properties], named:
//      - 'X' and "Y",
//      - Auto-generate [two] [private fields] with the same data type,
//      - Which will be allocated on the [stack].
// 3.  add [constructor] to:
//      - set initial values for X and Y.
// 4.  add [operator ] to
//      - [add] two instances together that
//      - [returns] a new instance of the type, with X added to X, and Y added to Y
