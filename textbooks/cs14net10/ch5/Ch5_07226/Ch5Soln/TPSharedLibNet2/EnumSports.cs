namespace TPNS.TPSharedLibNet2;

[Flags]
public enum EnumByteSports
{
    None            = 0,
    Tennis          = 1 << 0,
    Football        = 1 << 1,
    Skateboarding   = 1 << 2,
    Snowbarding     = 1 << 3,
    Golf            = 1 << 4,
    Badminton       = 1 << 5,
    Pickleball      = 1 << 6,
}

public enum EnumSports : byte
{
    None,
    Tennis,
    Football,
    Skateboarding,
    Snowbarding,
    Golf,
    Badminton,
    Pickleball,
}
