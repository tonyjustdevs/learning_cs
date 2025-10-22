
using TPSharedNamespace;

Person tony         = new();
tony.Name           = "tony abalone";
tony.DOB            = new DateTime(2025, 04, 01);                              // tony.DOB = DateTime.Now;
tony.FavSuburb      = SydneySuburbs.Saigon;                             // 36 = 32 + 4 
//tony.FavSuburb      = SydneySuburbs.Townhall;                             // 36 = 32 + 4 
//tony.FavSuburbs     = SydneySuburbsListBytes.Blacktown | SydneySuburbsListBytes.DulwichHill;
tony.FavSuburbs = (SydneySuburbsListBytes)69;

// use method 1 & method to store FavSuburbs
// method 1: set enumlist by combing enum values with | operator
// method 2: use final (sum) value, then (type-convert) -> Type: SydneySuburbsListBytes
Console.WriteLine($"Hello [{tony.Name}]\n" +
    $"born [{tony.DOB}]\n" +
    $"lives in [{tony.FavSuburb}] [{(int)tony.FavSuburb}] (exp: -2147483648)\n" +
    $"likes suburbs: [{tony.FavSuburbs} {(int)tony.FavSuburbs}] (exp: 69=64+4+1)\n"); //64+4+1


