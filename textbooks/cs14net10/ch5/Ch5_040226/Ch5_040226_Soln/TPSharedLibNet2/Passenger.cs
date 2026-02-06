
namespace TPNS.TPSharedLibNet2;

public class Passenger
{
    public string? Name { get;set; }
}

public class FirstClassPassenger : Passenger
{
    public double AirMiles;
    public override string ToString()
    {
        return string.Format("I'm mr 1st-class with {0} miles!", AirMiles);
    }
}

public class BusinessClassPassenger : Passenger
{
}

public class CoachClassPassenger : Passenger
{
    public double CarryOnKG;
    public override string ToString()
    {
        return string.Format("I'm a peasant with {0} kg baggage!", CarryOnKG);
    }

}
