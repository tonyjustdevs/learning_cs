
// [1. ]  create two interfaces
// [1a.]  - interface_1 "INoneInterface": 1 req_methd + 0 imps
// [1b.]  - interface_2 "ISomeInterface": 1 req_methd + 1 imps (can be overriden)

// [2. ]  add abstract class
// [2a.]  - 'abstract': 1 req_methd (must be implemented by derived type)
// [2b.]  - 'virtual': can be overriden method       


FullyImplemented imfullyready = new();
imfullyready.Alpha();   
imfullyready.Beta();

public interface INoImplemented     // C#1+
{
    void Alpha();                   // [REQUIRED]  must be implemented by Derived type
}

public interface ISomeImplemented   // C#8+
{
    void Alpha();                   // [REQUIRED] must be implemented by Derived type
    void Beta()                     => Console.WriteLine("Beta() @ ISomeImplemented"); // Implementation can be overriden!
}
public abstract class AbsPartiallyImplemented
{                                   // TODO: 1 required + 1 overridble method
    public abstract void Gamma();   // [REQUIRED] must be implemented by Derived type
    public virtual void Delta()     => Console.WriteLine("Delta() @ AbsPartiallyImplemented"); 
}

public class FullyImplemented : AbsPartiallyImplemented, ISomeImplemented, INoImplemented
{
    public void Alpha()             => Console.WriteLine("Alpha() @ FullyImplemented");
    public override void Gamma()    => Console.WriteLine("Gamma() @ FullyImplemented");
}