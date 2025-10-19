
using TPCh5SharedLibrary;

Person tony = new();
tony.name = "tony";
tony.dob = new DateTimeOffset(
    year: 2025, month: 10, day: 19,
    hour: 9, minute: 55, second: 56,
    offset: TimeSpan.FromHours(7));
tony.wonder = WondersOfSydney.DulwichHill;
tony.bucketlist = CoolPlaces.HongKong | CoolPlaces.Brazil;
tony.pets = Pets.Cat | Pets.Dog | Pets.Rabbit | Pets.Snake;


Person messi = new()
{
    name = "messi",
    dob = new DateTimeOffset(),
    wonder = WondersOfSydney.Auburn,
    bucketlist = CoolPlaces.Zambia | CoolPlaces.NewYork,
    pets = Pets.None
};

/// print results /// 


Console.WriteLine("Hello, TP'S People App!");
Console.WriteLine($"Person created: {tony} (exp: TPCh5SharedLibrary.Person)");

Console.WriteLine($"tony.name: {tony.name} (exp: tony)");
Console.WriteLine($"tony.dob: { tony.dob:F}");
Console.WriteLine($"tony.wonder: { tony.wonder} [{(int)tony.wonder}] (enum)");
Console.WriteLine($"tony.bucketlist: { tony.bucketlist} [{(int)tony.bucketlist}] (enum bytes: hk 16 + brazil 2)");
Console.WriteLine($"tony.pets: { tony.pets} [{(int)tony.pets}] (all pets: 1+2+4+8=15)");

Console.WriteLine($"messi.name: {messi.name} (exp: messi)");
Console.WriteLine($"messi.dob: {messi.dob:F}");
Console.WriteLine($"messi.wonder: {messi.wonder} [{(int)messi.wonder}]");
Console.WriteLine($"messi.bucketlist: {messi.bucketlist} [{(int)messi.bucketlist}] (zambia 128 + ny 64)");
Console.WriteLine($"messi.pets: {messi.pets} [{(int)messi.pets}] (0 None)");

