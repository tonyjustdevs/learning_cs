namespace TPNS.TPSharedLibNet2;

public enum EnumSports
{
    None,
    Golf,
    Surfing,
    Tennis,
    Football,
    Snowboarding,
    Badminton,
    Pickleball

}

[Flags]
public enum EnumByteSports : byte
{
    None            = 0     ,   // 0
    Golf            = 1 << 0,   // 1
    Surfing         = 1 << 1,   // 2
    Tennis          = 1 << 2,   // 4
    Football        = 1 << 3,   // 8
    Snowboarding    = 1 << 4,   // 16
    Badminton       = 1 << 5,   // 32
    Pickleball      = 1 << 6,   // 64

}
