
using TPCh5SharedLibrary;

Person tony = new();
tony.name = "tony";
//tony.dob = new DateTimeOffset(new DateTime(2025,10,19),new TimeSpan(7,0,0));
//tony.dob = new DateTimeOffset(DateTime.Now);


tony.dob = new DateTimeOffset(
    year: 2025, month: 10, day: 19,
    hour: 9, minute: 55, second: 56,
    offset: TimeSpan.FromHours(7));

Person messi = new()
{
    name = "messi",
    dob = new DateTimeOffset()
};

/// print results /// 


Console.WriteLine("Hello, TP'S People App!");
Console.WriteLine($"Person created: {tony} (exp: TPCh5SharedLibrary.Person)");

Console.WriteLine($"tony.name: {tony.name} (exp: tony)");
Console.WriteLine($"tony.dob: { tony.dob:F}");

Console.WriteLine($"messi.name: {messi.name} (exp: messi)");
Console.WriteLine($"messi.dob: {messi.dob:F}");

