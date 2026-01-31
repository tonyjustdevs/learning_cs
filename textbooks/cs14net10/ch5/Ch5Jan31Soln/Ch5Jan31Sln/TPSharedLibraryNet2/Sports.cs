
namespace TPNS.TPSharedLibraryNet2;

[Flags]
public enum EnumBytePopSports : byte
{
    Swimming        =  0b_0000_0001, // 1
    Tennis          =  0b_0000_0010, // 2
    Golf            =  0b_0000_0100, // 4
    Football        =  0b_0000_1000, // 8
    Badminton       =  0b_0001_0000, // 16
    Volleyball      =  0b_0010_0000, // 32    
    Pickleball      =  0b_0100_0000, // 64  

    // 0001_0010: 18 (Storing 18 as bits in an enum)

}


public enum EnumPopSports
{
    Football,
    Tennis,
    Golf,
    Swimming,
    Badminton,
    Volleyball,
    Pickleball
}