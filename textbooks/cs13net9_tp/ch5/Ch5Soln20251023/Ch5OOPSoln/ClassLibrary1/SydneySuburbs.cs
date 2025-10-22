namespace TPSharedNamespace;

public enum SydneySuburbs
{
    Auburn,     //  0
    Sydney,     //  1
    DulwichHill,//  2
    Townhall,   //  3
    Chatswood,  //  4 
    Blacktown,  //  5 
    Rhodes,     //  6 
    Saigon = 1<< 31  // -> 10000000-00000000-00000000-00000000: -2,147,483,648 if youre a mad man
}

[Flags]
public enum SydneySuburbsListBytes : byte
{
    None        = 0b_00000000, //   0
    Auburn      = 0b_00000001, //   1
    Sydney      = 0b_00000010, //   2
    DulwichHill = 0b_00000100, //   4
    Townhall    = 0b_00001000, //   8
    Chatswood   = 0b_00010000, //  16
    Blacktown   = 0b_00100000, //  32
    Rhodes      = 0b_01000000  //  64
}