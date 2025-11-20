

// 1. [create two Interfaces]:
//    - same method/params (auto public, mbrs always public)
//    - without implementation, ie signature only

// 2. [create class]/type: "must implement both Interfaces"  
//    - add implicit implementation
//    - add explicit implementation

// 3. [calling implementations]
//    - call implicit implementation {           obj.Method()   }
//    - call explicit implementation ( Intface obj ).Method()   }

namespace TP.SharedLibraries;

public class Driver : IDriveCar, IDriveScooter
{
    public void Drive()
    {
        Console.WriteLine("I usually drive a car!");

    }
    void IDriveScooter.Drive()
    {
        Console.WriteLine("I also drive a scooter...");
    }
}   // add Drive cls & IDriveCar IDriveScooter interfaces 191125

public interface IDriveCar
{
    void Drive();
}
public interface IDriveScooter
{
    void Drive();
}
