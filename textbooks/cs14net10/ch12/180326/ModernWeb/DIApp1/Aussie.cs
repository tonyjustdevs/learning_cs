namespace DI.Models;

public class AussieBogan : Aussie { }

public class Aussie : IGreeter
{
    static int greet_no;
    public Aussie()
    {
        greet_no++;
        Console.WriteLine($"\nAussie() constructor()  [{greet_no}]");
    }

    public void DoGreet() 
    {
        Console.WriteLine($"\n'gday mate!' [{greet_no}]");
    }
    //void IGreeter.DoGreet()
    //{
    //    Console.WriteLine($"\nIGreeter.DoGreet() called [{greet_no}]");
    //}
}
