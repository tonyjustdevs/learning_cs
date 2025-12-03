
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


DispVector2 dv2_1 = new(3, 5);
DispVector2 dv2_2 = new(-2, 7);
Console.WriteLine();
Console.WriteLine($"dv2_1: {dv2_1}");
Console.WriteLine($"dv2_2: {dv2_2}");
Console.WriteLine($"dv2_1+dv2_2: {dv2_1 + dv2_2}");

Console.WriteLine("Testing Equality Between Different Struct Types:\n");
Console.WriteLine($"dv2_1: {dv2_1}");
Console.WriteLine($"d1: {dv1}");
Console.WriteLine($"dv1.Equals(dv2_1): {dv1.Equals(dv2_1)} (true: custom Equals logic) ");
Console.WriteLine($"dv1==dv2_1: {dv1 == dv2_1}  ");

// ADD COMPARISON FUNCTION BY FIELDS...
Console.WriteLine($"CompareDisplacementVectors(dv1, dv2_1):{DispVectComparer.CompareDisplacementVectors(dv1, dv2_1)}");
