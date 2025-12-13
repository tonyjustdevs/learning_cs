using Northwind.EntityModels;

Console.WriteLine("[Program.cs] Hello, WorkingWithEFCore!\n");
Console.WriteLine("[Program.cs] Creating DB Instance\n");

NorthwindDb3 db3 = new();

Console.WriteLine($"[Program.cs] db3.Database.ProviderName:{db3.Database.ProviderName}");

