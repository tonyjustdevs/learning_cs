// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//byte[] buffer = { 10, 20, 30, 40, 50 };
//ReadOnlySpan<byte> RObuffer = buffer;
//ReadOnlySpan<byte> RObuffer = new byte[] { 10, 20, 30, 40, 50 };

Console.WriteLine("Whats a dozen? ");
string? input_str = Console.ReadLine();
if (int.TryParse(input_str, out int result))
{
    Console.WriteLine($"Sucessfully parsed {input_str} to {result}");
}
else
{
    Console.WriteLine($"Could not parsed {input_str}!");

}

