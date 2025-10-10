//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter an integer: ");

//try
//{
//    string? input_str = Console.ReadLine();
//    int result_int = int.Parse(input_str);
//    Console.WriteLine($"result: {result_int}");
//}
////catch (Exception)
//catch
//{
//    //Console.WriteLine($"sumtin wong");
//	throw;
//}


Console.WriteLine("Before parsing");
Console.Write("What is your age? ");

string? input = Console.ReadLine();

try
{
    int age = int.Parse(input!);
    Console.WriteLine($"You are {age} years old.");
}
catch (FormatException fe)
{
    Console.WriteLine($"learn to write bro: [{fe.GetType()}][{fe.Message}]");
}
catch (OverflowException oe)
{
    Console.WriteLine($"you think youre a big shot now ha! : [{oe.GetType()}][{oe.Message}]");
}
catch (Exception ex)
{    
    Console.WriteLine($"{ex.GetType()}: {ex.Message} | {ex.Source}");
}

Console.WriteLine("After parsing");
