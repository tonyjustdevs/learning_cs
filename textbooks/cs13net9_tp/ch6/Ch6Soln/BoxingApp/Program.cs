Console.WriteLine("Hello, Boxing App!");


int a = 69;
object boxed_a = a;
int unboxed_a  = (int) a;


Console.WriteLine($"int a: {a}");
Console.WriteLine($"object boxed_a = a = {boxed_a}");
Console.WriteLine($"int unboxed_a = (int) a = {unboxed_a}");

// 2/12/25 continue ch06-memory.md before chapter 7
// https://github.com/markjprice/cs14net10/blob/main/docs/ch06-memory.md


// boxing app v2

char some_char = 'a';
object boxed_char = some_char;
char unboxed_char = (char)boxed_char;


int cool_int = 5;
System.Int32 cool_int2 = 6;

Console.WriteLine($"[int] cool_int.GetType(): {cool_int.GetType()}");
Console.WriteLine($"[System.Int32] cool_int2.GetType(): {cool_int2.GetType()}");





















