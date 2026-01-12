Console.WriteLine("Hello BitwiseOperator App!");

int a = 10;
int b = 6;

int[] print_widths = [10, 10,11];
// 1234567890123456789012345678901
// expression   decimal     binary
// -10               10          9
// a&b              128   00000000             
Console.WriteLine($"{"expression",-10} {"decimal",10} {"binary",11}");
Console.WriteLine($"{"a",-10} {a,10} {a,11:B8}");
Console.WriteLine($"{"b",-10} {b,10} {b,11:B8}");
//Console.WriteLine($"{"variable",-9} {a:,9} {b,9}");

// 10 

// 6