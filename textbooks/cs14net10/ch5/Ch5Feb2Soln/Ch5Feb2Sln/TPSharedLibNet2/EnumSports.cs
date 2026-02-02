namespace TPNS.TPSharedLibNet2;

public enum EnumSports
{
    None,
    Football,
    Golf,
    Snowboarding,
    Pickleball,
    Badminton,
    Surfing,
    Tennis,
}

[Flags]
public enum EnumByteSports : byte
{
    None            = 0,      // 0b_0000_0000 - 0
    Football        = 1 << 0, // 0b_0000_0001 - 1
    Golf            = 1 << 1, // 0b_0000_0010 - 2
    Snowboarding    = 1 << 2, // 0b_0000_0100 - 4
    Pickleball      = 1 << 3, // 0b_0000_1000 - 8
    Badminton       = 1 << 4, // 0b_0001_0000 - 16
    Surfing         = 1 << 5, // 0b_0010_0000 - 32
    Tennis          = 1 << 6, // 0b_0100_0000 - 64

    // Test_69 == Tennis(64) + Snowboarding(4) + Football(1)
    // Test_PickleballGolfSurfing == 8+2+32 == 42
}