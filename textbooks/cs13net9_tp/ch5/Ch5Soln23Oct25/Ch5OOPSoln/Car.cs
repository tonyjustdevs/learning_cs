
internal class Car
{
    private int Wheels { get; set; }
    
    public bool IsEV { get; set; }
    
    internal void Start()
    {
        Console.WriteLine("Starting...");
    }

    public void DoStart()
    {
        Car.Start(this);
    }
}

//class Car
//{
//    int Wheels { get; set; }
//    public bool IsEV { get; set; }
//    internal void Start()
//    {
//        Console.WriteLine("Starting...");
//    }
//}