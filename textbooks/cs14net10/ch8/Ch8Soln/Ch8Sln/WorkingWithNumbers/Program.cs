using System.Numerics;

Console.WriteLine("Hello, World!");

ulong a_ulong_nbr = ulong.MaxValue;
//int cwidth = 40;
BigInteger a_bigint_nbr = new BigInteger(012345678901234567890);
BigInteger a_bigint_nbr2 = new(12345678901234567890);
BigInteger a_bigint_nbr3 = BigInteger.Parse("1234567890123456789012345678901234567890");


BigInteger a_bigint_nbr4 = BigInteger.Parse(
    "1234567890123456789012345678901234567890" +
    "1234567890123456789012345678901234567890");

//a_bigint_nbr = 1234567890123456789012345678901234;
Console.WriteLine("Chapter 8: Common .NET types");
Console.WriteLine("\n[1] Testing Large Values:");
Console.WriteLine($"a_ulong_nbr: {a_ulong_nbr,40:N}");
Console.WriteLine($"a_bigint_nbr: {a_bigint_nbr,40:N}");
Console.WriteLine($"a_bigint_nbr2: {a_bigint_nbr2,40:N}");
Console.WriteLine($"a_bigint_nbr3: {a_bigint_nbr3,40:N}");
Console.WriteLine($"a_bigint_nbr4: {a_bigint_nbr4,40:N}");

Console.WriteLine("\n[2] Testing Multiplying Large Values:");
// get max if int
Console.WriteLine($"int.MaxValue: {int.MaxValue:N0}");
int a = 2;
int b = 2_000_000_000;
Console.WriteLine($"a: {a:N0} ({a.GetType()}), b: {b:N0} ({b.GetType()})");
Console.WriteLine($"[2.1] a*b: {a*b:N0} ({(a*b).GetType()})");
Console.WriteLine($"[2.2] int.BigMul(a,b): {int.BigMul(a,b):N0} ({(int.BigMul(a, b)).GetType()})");
Console.WriteLine($"[2.3] Math.BigMul(a,b): {Math.BigMul(a, b):N0} ({(Math.BigMul(a, b)).GetType()})");
Console.WriteLine($"[2.4] Math.BigMul(b,1/b): {Math.BigMul(b, 1/b):N0} ({(Math.BigMul(b, 1/b)).GetType()})");