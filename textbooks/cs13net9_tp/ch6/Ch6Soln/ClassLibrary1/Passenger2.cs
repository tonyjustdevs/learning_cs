using System.Numerics;

namespace TP.SharedLibraries;

public class EconomyPlus : Passenger
{
    public int Points;
    public override void Greeting() => Console.WriteLine("Aye, Upgraded Peasant..."); 
}

public class Staff: Passenger
{
    public override void Greeting() => Console.WriteLine("Get Back To Work...");
}
