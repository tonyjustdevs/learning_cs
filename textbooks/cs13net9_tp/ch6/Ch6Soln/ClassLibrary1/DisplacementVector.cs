
using System.Diagnostics.CodeAnalysis;

namespace TP.SharedLibraries;

public struct DisplacementVector
{
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

    public static bool operator ==(DisplacementVector dv1, DispVector2 dv2)
    {
        Console.WriteLine($"Comparing DisplacementVector 'dv1' & DispVector2 'dv2' individual fields...");
        return dv1.X == dv1.X && dv1.Y == dv2.Y ? true : false;
        //return dv1.Equals(dv2);
    }
    public static bool operator !=(DisplacementVector dv1, DispVector2 dv2)
    {
        Console.WriteLine($"Comparing DisplacementVector 'dv1' & DispVector2 'dv2' individual fields...");
        return dv1.X == dv1.X && dv1.Y == dv2.Y ? true : false;
        //return dv1.Equals(dv2);
    }


    #region Methods
    public override string ToString()
    {
        return $"(x: {X}, y: {Y})";
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {   // note: 'obj' is the second type being compared: aka DispVector2 
        // we are comparing og-struct-type 'DisplacementVector' & 'DispVector2'
        // 1. explicity conversion [obj] ---> [DispVector2]
        Console.WriteLine("[1] In overriden Equals() method inside DisplacementVector class");
        if (obj is null )
        {
            return false;
        }
        Console.WriteLine("[2] Converting passed in boxed object to DispVector2 dv2");

        //Console.WriteLine("[3] Comparing fields (X,Y) of different struct types DisplacementVector (.this) & DispVector2 (dv2)");
        if (obj is DisplacementVector dv2)
        {
            return X == dv2.X && Y == dv2.Y ? true : false; //dv1(.this not nec, since in og-DV class) vs dv2
        }
        else if (obj is DispVector2 dv3)
        {
            return X == dv3.X && Y == dv3.Y ? true : false; //dv1(.this not nec, since in og-DV class) vs dv2

        }
        else
        {
            return false;
        }
    }
    #endregion


}


public record struct DisVec3_RS
{
    public int X { get; set; }
    public int Y { get; set; }

    public DisVec3_RS(int x, int y)
    {
        X = x;
        Y = y;
    }
}