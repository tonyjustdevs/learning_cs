
using TPSharedModernLib;

Console.WriteLine("Hello, World!");

Address addy = new(city: "Manchester City")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

WriteLine("addy.Region: {0}",addy.Region.Length);
WriteLine("addy.Building: {0}", addy.Building?.Length);

//Unhandled exception.
//System.NullReferenceException:
//Object reference not set to an instance of an object.
WriteLine("addy.Street: {0}", addy.Street?.Length);

Employee ee = new() { Name="jak",EmployeID = 10069 };
ee.WriteToConsole();
((Person)ee).WriteToConsole();
//var pee = (Person)ee;
//pee.WriteToConsole();

WriteLine(ee.ToString()); //TPSharedModernLib.Address (before override)
