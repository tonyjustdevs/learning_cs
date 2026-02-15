using System.Runtime.InteropServices;
Console.WriteLine("Hello, World!");
Console.WriteLine($"OSArchitecture: {RuntimeInformation.OSArchitecture}");
Console.WriteLine($"RuntimeIdentifier: {RuntimeInformation.RuntimeIdentifier}");
Console.WriteLine($"FrameworkDescription: {RuntimeInformation.FrameworkDescription}");
Console.WriteLine("Press any key to stop me.");
Console.ReadKey(intercept: true); // Do not output the key that was pressed.