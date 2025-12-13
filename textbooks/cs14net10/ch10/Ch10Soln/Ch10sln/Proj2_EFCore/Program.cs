
//using Microsoft.EntityFrameworkCore;
using Proj2.NorthWind.EntityModels;
Console.WriteLine("Hello, Proj 2!");

// [1] add database instance
NWDB northwind_db = new();
Console.WriteLine($"[p.cs] northwind_db: {northwind_db}");
Console.WriteLine($"[p.cs] northwind_db.Database: {northwind_db.Database}");
Console.WriteLine($"[p.cs] northwind_db.Database.ProviderName: {northwind_db.Database.ProviderName}");

// [2] add model entities
