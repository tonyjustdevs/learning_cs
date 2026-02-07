namespace TPNS.TPSharedModernLib;

public class Passenger
{
    public string? Name;
}

public class BusinessClass: Passenger
{
    public override string ToString()
    {
        return "I'm a boss";
    }
}

public class FirstClass : Passenger
{
    public double AirMiles;
    public override string ToString()
    {
        return $"I'm first class with {AirMiles} airmiles";
    }
}

public class CoachClass : Passenger
{
    public double CarryOnKg;
    public override string ToString()
    {
        return $"I'm peasant class with {CarryOnKg} Carry-on kgs";
    }
}