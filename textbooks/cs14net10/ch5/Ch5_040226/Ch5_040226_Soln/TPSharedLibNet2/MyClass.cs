namespace TPNS.TPSharedLibNet2;

public partial class MyClass
{
    // declaration, no implementation

    partial void OnSomething();

    public void DoMainJob()
    {
        // some crap //
        OnSomething();
    }
}
