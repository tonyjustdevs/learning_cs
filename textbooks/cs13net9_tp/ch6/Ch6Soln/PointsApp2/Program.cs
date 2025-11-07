using System.Numerics;
using TP.SharedLibraries;
Console.WriteLine("Welcome to Points App 2");

Player2 p = new();
p.Achieved100Points += some_subbed_fn;
await p.AddPoints(10);
await p.AddPoints(20);
await p.AddPoints(40);
await p.AddPoints(80);


void some_subbed_fn(int points)
{
    Console.WriteLine($"Congratulations from Program.cs, you've reached over {points} points");

}