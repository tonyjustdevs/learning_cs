
//internal class Car
public class Car
{   
    //private int Wheels { get; set; } //v1
    public int Wheels { get; private set; }    //v2 new(){ Wheels=4, IsEV=true} this wont work BC of private set

    public bool IsEV { get; set; }
    
    //internal void Start()
    public void Start()
    {
        Console.WriteLine("Starting...");
    }

    // create initializer

    public Car() { }
    public Car(int wheels) 
    {
        Wheels = wheels;
    }

    public Car(int wheels, bool isEV) 
    {
        Wheels = wheels;
        IsEV = isEV;    
    }   

    //public void DoStart()
    //{
    //    this.Start();
    //}
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