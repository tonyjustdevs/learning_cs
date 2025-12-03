namespace TP.SharedLibraries;

public struct DispVector2
{
    public int X { get; set; }
    public int Y { get; set; }


    #region Constructors
    public DispVector2(int x, int y)
    {
        X = x;
        Y = y;
    }
    #endregion
    
    
    #region Operators
    public static DispVector2 operator+(DispVector2 dv1, DispVector2 dv2)
    {
        return new DispVector2(dv1.X + dv2.X, dv1.Y + dv2.Y);
    }

    public static bool operator==(DispVector2 dv1, DispVector2 dv2)
    {
        return dv1.Equals(dv2); // v1
    }
    public static bool operator !=(DispVector2 dv1, DispVector2 dv2)
    {
        return !dv1.Equals(dv2); // v1
    }

    #endregion


    #region Methods
    public override string ToString()
    {
        return $"(x: {X}, y: {Y})";
    }
    #endregion


}
