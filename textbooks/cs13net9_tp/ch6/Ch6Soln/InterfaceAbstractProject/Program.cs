
using TP.SharedLibraries;

Console.WriteLine("Hello Inteface Abstract Project\n");
FullyImplementedAbstractClass FImp_instance = new();

FImp_instance.Alpha_Req();
FImp_instance.Delta();
((ISomeImplementation)FImp_instance).Beta();
FImp_instance.Gamma_Req();

// 1. itf none imp
public interface INoImplementation
{
    void Alpha_Req();
}
// 2. itf some imp
public interface ISomeImplementation
{
    void Alpha_Req();
    void Beta() =>Console.WriteLine("I'm Beta() in INoImplementation\n");
}

public abstract class PartiallyImplementedAbstractClass
{ // 3. abs partial imp
    public virtual void Delta() => Console.WriteLine("I'm Delta() in PartiallyImplementedAbstractClass\n");     // implemented
    public abstract void Gamma_Req();       // required
}

// 4. full imp
//public abstract class FullyImplementedAbstractClass : PartiallyImplementedAbstractClass, INoImplementation, ISomeImplementation
public class FullyImplementedAbstractClass : PartiallyImplementedAbstractClass, INoImplementation, ISomeImplementation
{
    public void Alpha_Req()
    {
        Console.WriteLine("Alpha_Req() imp in FullyImplementedAbstractClass req by INoImp\n");
    }

    public override void Gamma_Req()
    {
        Console.WriteLine("Gamma_Req() overriden in FullyImplementedAbstractClass\n");
    }
}

