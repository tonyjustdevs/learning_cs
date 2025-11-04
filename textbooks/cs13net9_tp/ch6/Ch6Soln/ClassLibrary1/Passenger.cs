namespace TP.SharedLibraries;

public class Passenger
{
    public string? Name;
    public int SeatNo;
    public virtual void Greeting() { Console.WriteLine("im an imaginary psgr!"); }
}

public class BusinessClass : Passenger 
{
    public int AirMiles;
    public override void Greeting() { Console.WriteLine("Hello, Mr Business Person"); }
}

public class EconomyClass : Passenger
{
    public int KmsByBus;
    public override void Greeting() { Console.WriteLine("Hi, Peasant!"); }
}

public class FirstClass : Passenger
{
    public override void Greeting() { Console.WriteLine("Greetings, Lord Of the Skies!"); }
}