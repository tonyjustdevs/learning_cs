namespace TP.SharedLibraries;

public class Car2
{
    public string? Model { get; set; }
    public string? Colour{ get; set; }


}

public static class Car2Extensions          // 1.  [car2ext.cs] add static    class:    [Car2Extensiosns]
{                                           // 2.  [car2ext.cs] add static method_1:    [SetModel]
    public static void SetModel(Car2 car_instance, string? model)
    {
        car_instance.Model = model;
    }
    public static void SetModel2(this Car2 car_instance, string? model)
    {
        car_instance.Model = model;
    }

}
// test 3
// 1. add camry = Car2() instance & print
// 2. set camry.Model = "Toyota Camry" (manual) & print
// 3. chg Car2Extensions.SetModel(camry, "Hyundae Getz") (static method)
// 4. UPDATE Car2Extensions SetModel v2 to be extension method
// 5. chg Car2Extensions.SetModel(camry, "Hyundae Getz") (extension method) 
// 3a.  [car2ext.cs] add static method_2:    Takes Car and SetsModel(Car)
// 3b.  [car2ext.cs] add static method_2:    [SetColour]


// 4.  [program.cs] add car instance:       [obj]
// 5.  [program.cs] run method_chaining:    [obj.SetModel(...).SetColour()]

// add regular method
// add Extension for method chaining
//  Extension methods allow adding new methods to existing types without
//  modifying their source code or creating a new derived type.
