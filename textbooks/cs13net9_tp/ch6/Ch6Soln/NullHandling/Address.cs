
using System.IO;

namespace NullHandling;

public class Address
{   
    public string? Building;
    public string Street=string.Empty;
    public string Region;
    public string City;

    public Address()
    {
        Region = string.Empty;
        City = string.Empty;
    }
    public Address(string ct): this()
    {
        City = ct;
    }

}

// [1] Assign {empty} str-value [Street] field,
// [2] Define Constructors():
//      - Set [Building], [Region], [City] to empty (because non-nullable)
// [3] Call the default parameterless constructor



