double c = 9.8;

int d = (int)c; // Compiler gives an error if you do not explicitly cast.
//int d = c; // Compiler gives an error if you do not explicitly cast.
Console.WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

MyClass myClass = new();

object obj = myClass;

class MyClass()
{
    string a;
}