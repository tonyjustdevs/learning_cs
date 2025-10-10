
//Console.WriteLine($"{"Integer Max Value",18}   {"Increment",10}   {"Value",15}");
//for (int i = -2; i < 5; i++)
//{
//    Console.WriteLine($"{int.MaxValue,18} + {i,10} = {int.MaxValue+i,15}");
//}

//Console.WriteLine();


//Console.WriteLine($"{"Integer Min Value",18}   {"Increment",10}   {"Value",15}");
//for (int i = 2; i >= -5; i--)
//{
//    Console.WriteLine($"{int.MinValue,18} + {i,10} = {int.MinValue + i,15}");
//}

//Console.WriteLine("now with checked: ");

checked { 
    Console.WriteLine($"{"Integer Max Value",18}   {"Increment",10}   {"Value",15}");
    for (int i = -2; i < 5; i++)
    {
        Console.WriteLine($"{int.MaxValue,18} + {i,10} = {int.MaxValue + i,15}");
    }
}//Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.

Console.WriteLine();

checked { 
    Console.WriteLine($"{"Integer Min Value",18}   {"Increment",10}   {"Value",15}");
    for (int i = 2; i >= -5; i--)
    {
        Console.WriteLine($"{int.MinValue,18} + {i,10} = {int.MinValue + i,15}");
    }
}