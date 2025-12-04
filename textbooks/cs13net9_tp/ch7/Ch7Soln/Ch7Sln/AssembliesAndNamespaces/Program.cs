using System.Xml.Linq;
using System;
//using Math;
XDocument xdoco = new();
//Console.WriteLine("Hello, World!");
//Console.WriteLine($"xdoco: {xdoco}");
//Console.WriteLine($"xdoco_type: {xdoco.GetType()}");

// C# keywords are aliases to .NET types
// - which are types living
// - in class library assemblies

// ie:
// - C# keyword 'int'        is a .NET type 'System.Int32'
// - C# keyword 'string'     is a .NET type 'System.String'

String a = "aaa";
string b = "bbb";

System.Console.WriteLine($"a: {a}, {a.GetType()}, {a.GetTypeCode()}");
System.Console.WriteLine($"b: {b}, {b.GetType()}, {b.GetTypeCode()}");

Console.WriteLine();
Console.WriteLine($"Native Integer Testing:");
Console.WriteLine(Environment.Is64BitOperatingSystem);


Console.WriteLine($"int.MaxValue: \t\t{int.MaxValue:N0}");
Console.WriteLine($"Math.Pow(2,32)/2-1: \t{(Math.Pow(2, 32)/2-1)}");
Console.WriteLine();
Console.WriteLine($"nint.MaxValue: \t\t{nint.MaxValue:N0}");
Console.WriteLine($"Math.Pow(2,64)/2-1: \t{((Math.Pow(2, 64)/2)-5)} (cant print all");

