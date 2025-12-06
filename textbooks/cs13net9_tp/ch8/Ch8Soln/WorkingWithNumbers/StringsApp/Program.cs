Console.WriteLine("Hello to StringsApp!");

// 1. add single string with seperator
// 2. add apply Split and assing to array
// 3. loop through each city

Console.WriteLine("[1] String Manipulation");
string one_long_str = "sydney,paris,barcelona,london,beijing";
string[] city_array = one_long_str.Split(',');
foreach (string city in city_array) Console.WriteLine(city) ;

Console.WriteLine("\n[1] Content Checking");
string stringToCheck    = "Alphabet";
string stringContains   = "bet";
Console.WriteLine($"stringToCheck.Contains(bet): {stringToCheck.Contains(stringContains)}");
Console.WriteLine($"stringToCheck.StartsWith('a'): {stringToCheck.StartsWith('a')}");
Console.WriteLine($"stringToCheck.StartsWith('A'): {stringToCheck.StartsWith('A')}");
