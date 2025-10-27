namespace TP.SharedNamespace;

public partial class MyClass
{
    partial void DoSomethingDuringWork();

    public void actualWork() => DoSomethingDuringWork();

};



public partial class MyOtherClass
{
    partial void HaveACiggie();

    public void GoToWork()
    {
        HaveACiggie();
    }
    
}

public partial class MyOtherClass
{
    // declare partial method
    partial void HaveACiggie() {
        Console.WriteLine("smoked a menthol ciggie");
    }
}