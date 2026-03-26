namespace DI.Models;

public class Japanese : IGreeter
{
    static int greet_no;
    public Japanese()
    {
        greet_no++;
        Console.WriteLine($"\nJapanese() constructor called [{greet_no}]");
    }

    public void DoGreet() 
    {
        Console.WriteLine($"\nJ'konichiwi san' [{greet_no}]");
    }
    //void IGreeter.DoGreet()
    //{
    //    Console.WriteLine($"\nIGreeter.DoGreet() called [{greet_no}]");
    //}
}
