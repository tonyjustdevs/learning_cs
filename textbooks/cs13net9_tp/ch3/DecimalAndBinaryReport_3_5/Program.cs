// headings
Console.WriteLine("{0,12}{1,34}","Decimal","Binary");

Console.WriteLine("{0,12}{0,34:B32}", int.MaxValue);

for (int i = 10; i >=-10; --i)
{
    Console.WriteLine("{0,12}{0,34:B32}", i);
}




Console.WriteLine("{0,12}{0,34:B32}" ,int.MinValue);


