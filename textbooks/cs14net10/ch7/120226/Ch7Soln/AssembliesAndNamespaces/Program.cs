
using System;
using System.Xml.Linq;
XDocument xdoc = new();
//Console.WriteLine("Hello Chapter 7");

#region 1: Mapping C# keywords to .NET types
// type 'string' vs 'String'

string s1 = "hello";
String s2 = "hello";

WriteLine($"string s1: {s1} [{s1.GetType()}]");
WriteLine($"String s2: {s2} [{s2.GetType()}]");

WriteLine($"Environment.Is64BitProcess = {Environment.Is64BitProcess}");
WriteLine($"Environment.Is64BitOperatingSystem = {Environment.Is64BitOperatingSystem}");
WriteLine($"Environment.IsPrivilegedProcess = {Environment.IsPrivilegedProcess}");
WriteLine($"int.MaxValue = {int.MaxValue:N0}"); //2^32 
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");
#endregion 
