using System.Runtime.InteropServices;

Console.WriteLine("Hello, .NET10 World!");

Console.WriteLine($"OS.IsMacOS(): {OperatingSystem.IsMacOS()}");
Console.WriteLine($"OS.IsWindowsVersionAtLeast(10,22K): " +
    $"{OperatingSystem.IsWindowsVersionAtLeast(major:10,build:22000)}");
Console.WriteLine($"OS.IsWindowsVersionAtLeast(10): " +
    $"{OperatingSystem.IsWindowsVersionAtLeast(major: 10)}");


Console.WriteLine($"RuntimeInformation.OSArchitecture: {RuntimeInformation.OSArchitecture}");
Console.WriteLine($"RuntimeInformation.RuntimeIdentifier: {RuntimeInformation.RuntimeIdentifier}");
Console.WriteLine($"RuntimeInformation.FrameworkDescription: {RuntimeInformation.FrameworkDescription}");
Console.WriteLine("Press any key to stop me.");
Console.ReadKey(intercept: true); // Do not output the key that was pressed.