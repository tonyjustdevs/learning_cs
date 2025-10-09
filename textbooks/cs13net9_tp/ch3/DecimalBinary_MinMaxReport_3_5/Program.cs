//headings
const int dec1 = 12;
const int bin1 = 34;
const string bin2 = "34:B32";
Console.WriteLine($"{"Decimal",dec1}{"Binary",bin1}");
Console.WriteLine("{0,12}{0,34:B32}",int.MaxValue   );
// int.max
//string formatted = string.Format("{0," + dec1 + "}{0," + bin2 + "}", int.MaxValue); //{0,12}{0,34:B32}
//
for (int i = -10; i <= 10; i++)
{
    Console.WriteLine($"{ i,12}{ i,34:B32}");
}

Console.WriteLine("{0,12}{0,34:B32}", int.MinValue+2);
Console.WriteLine("{0,12}{0,34:B32}", int.MinValue+1);
Console.WriteLine("{0,12}{0,34:B32}", int.MinValue-0);