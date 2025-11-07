

using TP.SharedLibraries;
Console.WriteLine("Welcome to Points App!");

Player p =new();
await p.AddPoints(10);
await p.AddPoints(40);
await p.AddPoints(20);
await p.AddPoints(50);

// [B] add [Program.cs]
// 1.  Create Player instance
// 2.  await p.AddPoints() 