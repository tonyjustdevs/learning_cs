
using TPCh5SharedLibrary;

Person tony = new();
tony.name = "tony";
tony.dob = new DateTimeOffset(
    year: 2025, month: 10, day: 19,
    hour: 9, minute: 55, second: 56,
    offset: TimeSpan.FromHours(7));
tony.wonder = WondersOfSydney.DulwichHill;


Person messi = new()
{
    name = "messi",
    dob = new DateTimeOffset(),
    wonder=WondersOfSydney.Auburn

};

/// print results /// 


Console.WriteLine("Hello, TP'S People App!");
Console.WriteLine($"Person created: {tony} (exp: TPCh5SharedLibrary.Person)");

Console.WriteLine($"tony.name: {tony.name} (exp: tony)");
Console.WriteLine($"tony.dob: { tony.dob:F}");
Console.WriteLine($"tony.wonder: { tony.wonder} [{(int)tony.wonder}]");

Console.WriteLine($"messi.name: {messi.name} (exp: messi)");
Console.WriteLine($"messi.dob: {messi.dob:F}");
Console.WriteLine($"messi.wonder: {messi.wonder} [{(int)messi.wonder}]");

