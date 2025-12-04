using System.Numerics;

namespace TP.SharedLibraries;

public record EarthPosition
{
    public int Longitude { get; set; }
    public int Latitude { get; set; }

    public EarthPosition() { }
    public EarthPosition(int longitude, int latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }

    public static EarthPosition operator+(EarthPosition ep1, EarthPosition ep2)
    {
        return new EarthPosition(ep1.Longitude + ep2.Longitude, ep1.Latitude + ep2.Latitude);
    }

    //public static bool operator==(EarthPosition ep1, EarthPosition ep2)
    //{

    //    return (ep1.Longitude == ep2.Longitude && ep1.Latitude == ep2.Latitude) ? true : false;
    //}
    //public static bool operator !=(EarthPosition ep1, EarthPosition ep2)
    //{

    //    return (ep1.Longitude == ep2.Longitude && ep1.Latitude == ep2.Latitude) ? true : false;
    //}

    #region OutputMethods
    public override string ToString()
    {
        return $"({Longitude},{Latitude})";
    }
    #endregion

}
