namespace TP.SharedNamespace;
// add 1st_Class: 3 tiers costs (2 + _ default) + [AirMiles-criteria]
// add Bus_Class: 1 tier (_)
// add Pes_Class: 2 tier (1 + _) + [CarryOnKG-criteria]

public class Passengers // single input: Name
{
    public string? Name;
}

public class BusinessPassengers: Passengers
{
    public override string ToString()
    {
        return $"I'm, {Name}, a Business Passenger.";
    }
}
public class FirstClassPassengers : Passengers // TODO: airmiles field
{
    public int AirMiles;
    public override string ToString()
    {
        return $"I'm, {Name}, a VIP.";
    }
}

public class EconomyPassengers : Passengers // TODO: add CarryOnKG field 
{
    public int CarryOnKG;
    public override string ToString()
    {
        return $"I'm, {Name}, a Peasant Passenger.";
    }

}
