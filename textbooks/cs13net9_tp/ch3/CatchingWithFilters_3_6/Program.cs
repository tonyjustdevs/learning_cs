
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

Console.WriteLine("Enter an amount: ");

string? amt_str = Console.ReadLine();

if (string.IsNullOrEmpty(amt_str)){ return; }

try
{
    int amt_int = int.Parse(amt_str);
    Console.WriteLine($"you entered {amt_int}");
}

catch (FormatException fe) when (amt_str.Contains("$"))
{
    Console.WriteLine($"Bro you cant type in $! {amt_str} [{fe.GetType()}] [{fe.Message}]");
    throw;
}
catch (FormatException fe)
{
    Console.WriteLine($"are you illiterate! {amt_str} [{fe.GetType()}] [{fe.Message}]");
	throw;
}