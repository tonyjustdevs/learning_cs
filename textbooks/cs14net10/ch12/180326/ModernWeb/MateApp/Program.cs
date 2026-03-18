// See https://aka.ms/new-console-template for more information
using Northwind.EntityModels;

Console.WriteLine("Hello, Mate!");

NorthwindContextLogger.WriteToNwLogs("hey mate");

await Task.Delay(2);
string s = null;