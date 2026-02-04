using Dumpify;
using TPNS.TPSharedLibNet2;
DumpConfig.Default.TableConfig.ShowMemberTypes = true;
DumpConfig.Default.MembersConfig.IncludeFields = true;
DumpConfig.Default.MembersConfig.IncludeProperties = true;
DumpConfig.Default.MembersConfig.IncludeNonPublicMembers = true;
DumpConfig.Default.MembersConfig.IncludePublicMembers = true;
DumpConfig.Default.MembersConfig.IncludeVirtualMembers= true;

Console.WriteLine("Welcome to PeopleWorld!");

Person bob = new()
{
    Name = "bob",
    Born = new DateTimeOffset(1990, 6, 1, 0, 0, 0, TimeSpan.FromHours(5)),
    //SportsByteFav = EnumByteSports.Tennis,
    SportsLiked = (EnumByteSports)69,
    //FavouriteColour = "red"
};

bob.Children.AddRange([         // add children
    new Person {Name="kid1", FavouriteColour="green"},
    new Person {Name="kid2", FavouriteColour="blue"},

]);

// Deconstruct
// get name and dob via deconstruction
//var (o_name, DateTime o_dob)= bob;
//WriteLine("name: {0} dob: {1} (via implicit Deconstruct())", o_name, o_dob);
//var (o_name,_,o_kiddos)= bob;

//bob.SportsByteFav = EnumByteSports.Golf;  // ok
bob.SportsByteFav = (EnumByteSports)8;      // ok:      one of the valid bits
//bob.SportsByteFav = (EnumByteSports)9;    // not-ok:  one of the valid bits
bob.SportsLiked = EnumByteSports.Golf| EnumByteSports.Surfing; // ok
//bob.SportsLiked = (EnumByteSports)69;     // ok
bob.Dump();// Dump

