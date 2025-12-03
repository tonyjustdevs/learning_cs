
using TP.SharedLibraries;
Console.WriteLine("Hello, Memory Program!");

DisplacementVector dv1 = new( 3,5);
DisplacementVector dv2 = new(-2,7);

Console.WriteLine($"dv1.X[{dv1.X}]+dv2.X[{dv2.X}] = dv1.X+dv2.X[{dv1.X+dv2.X}]");
Console.WriteLine($"dv1.Y[{dv1.Y}]+dv2.Y[{dv2.Y}] = dv1.Y+dv2.Y[{dv1.Y + dv2.Y}]");

Console.WriteLine("Default Values");    
DisplacementVector dv3 = new();

Console.WriteLine($"dv3.X: {dv3.X}");
Console.WriteLine($"dv3.Y: {dv3.Y}");

DisplacementVector dv2_v2 = new(-2, 7);
// compare dv2 vs dv2_v2  
Console.WriteLine($"dv2.Equals(dv2_v2): {dv2.Equals(dv2_v2)}");
Console.WriteLine($"dv2==dv2_v2: {dv2==dv2_v2}");
Console.WriteLine($"dv2!=dv1: {dv2!=dv1}");
