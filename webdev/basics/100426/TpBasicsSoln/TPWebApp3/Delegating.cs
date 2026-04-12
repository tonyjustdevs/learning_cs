namespace TPWebApp3;

public class Delegating
{
    public static Action<string> StrVoidDelegate = SayHello;
    public static void SayHello(string name) { Console.WriteLine("Hello, {0}!", name); }
}
