using Northwind.EntityModels;
using System.Diagnostics;

partial class Program
{
    static void AddIntsToList()
    {
        var sw = new Stopwatch();
        var list_of_ints = new List<int>();

        sw.Start();
        for (int i = 0; i < 1_000_000; i++)
        {
            list_of_ints.Add(i);
        }
        sw.Stop();
        WriteLine($"int-time: {sw.ElapsedMilliseconds}");
    }
    static void AddObjToList()
    {
        var sw = new Stopwatch();
        var list_of_ints = new List<object>();

        sw.Start();
        for (int i = 0; i < 1_000_000; i++)
        {
            list_of_ints.Add(i);
        }
        sw.Stop();
        WriteLine($"obj-time: {sw.ElapsedMilliseconds}");
    }

    static void TypeChecker<T>(T Tvalue)
    {
        WriteLine($"Tvalue: {Tvalue}");
        WriteLine($"Tvalue?.GetType(): {Tvalue?.GetType()}");
        WriteLine($"typeof(T): {typeof(T)}");
    }
    //static void TypeChecker<T>(T Tvalue, int JustAnInt)

    static void TypeChecker<T, T2>(T Tvalue, T2 Tvalue2)
    {
        WriteLine($"Tvalue: {Tvalue}");
        WriteLine($"Tvalue2: {Tvalue2}\n");

        WriteLine($"Tvalue?.GetType(): {Tvalue?.GetType()}");
        WriteLine($"Tvalue2?.GetType(): {Tvalue2?.GetType()}\n");

        WriteLine($"typeof(T): {typeof(T)}");
        WriteLine($"typeof(T2): {typeof(T2)}\n");
    }

    static void TypeChecker<T, T2, CoolBro69>(T Tvalue, T2 Tvalue2, CoolBro69 justAcoolvariable)
    {
        WriteLine($"Tvalue: {Tvalue}");
        WriteLine($"Tvalue2: {Tvalue2}");
        WriteLine($"justAcoolvariable: {justAcoolvariable}\n");

        WriteLine($"Tvalue?.GetType(): {Tvalue?.GetType()}");
        WriteLine($"Tvalue2?.GetType(): {Tvalue2?.GetType()}");
        WriteLine($"justAcoolvariable?.GetType(): {justAcoolvariable?.GetType()}\n");

        WriteLine($"typeof(T): {typeof(T)}");
        WriteLine($"typeof(T2): {typeof(T2)}");
        WriteLine($"typeof(justAcoolvariable): {typeof(CoolBro69)}\n");
    }

    static void TypeChecker<T>(T Tvalue, int JustAnInt)
    {
        WriteLine($"Tvalue: {Tvalue}");
        WriteLine($"Tvalue?.GetType(): {Tvalue?.GetType()}");
        WriteLine($"typeof(T): {typeof(T)}");

        WriteLine($"JustAnInt: {JustAnInt}");
        WriteLine($"JustAnInt?.GetType(): {JustAnInt.GetType()}");
        //WriteLine($"typeof(T): {typeof(T)}");
    }

    static void TypeChecker2<T>(T var1, int var2){} 
    static void TypeChecker2<T, T2>(T var1, T2 var2){}
    static void TypeChecker2<T>(int var1, T var2) { }
}

public class BetterList<T>
{
    public List<T> data = new();

    public void AddToList(T value)
    {
        data.Add(value);
    }
}