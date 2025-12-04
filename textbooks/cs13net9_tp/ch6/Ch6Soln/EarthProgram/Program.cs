using TP.SharedLibraries;

Console.WriteLine("Welcome to Earth Program!");

EarthPosition ep1 = new EarthPosition() { Longitude = 69, Latitude=420};
EarthPosition ep2 = new EarthPosition() { Longitude = 69, Latitude=420};
EarthPosition ep3 = new EarthPosition() { Longitude = 555, Latitude=666};

Console.WriteLine(ep1.ToString());
Console.WriteLine(ep2.ToString());
Console.WriteLine(ep3.ToString());

Console.WriteLine("\nCompare via '=':");
Console.WriteLine($"ep1==ep2: {ep1 == ep2}");
Console.WriteLine($"ep1==ep3: {ep1 == ep3}");

Console.WriteLine("\nCompare via 'Equals()':");
Console.WriteLine($"ep1.Equals(ep2): {ep1.Equals(ep2)}");
Console.WriteLine($"ep1.Equals(ep3): {ep1.Equals(ep3)}");
