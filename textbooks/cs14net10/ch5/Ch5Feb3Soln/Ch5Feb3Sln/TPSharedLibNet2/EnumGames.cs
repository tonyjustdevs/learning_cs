namespace TPNS.TPSharedLibNet2;

public enum EnumGames //public EnumGames? GameFavourite;
{
    None,
    DontStarveTogether,
    Terraria,
    MarioKart64,
    Pokemon,
    MonsterHunterRise,
    BanjoKazooie,
    Fifa
}

//public EnumByteGames? GameLiked;

[Flags]
public enum EnumByteGames : byte//public EnumGames? GameFavourite;
{
    None                = 0,        // 0000_0000 = 0
    DST                 = 1 << 0,   // 0000_0001 = 1  
    Terraria            = 1 << 1,   // 0000_0010 = 2
    MarioKart64         = 1 << 2,   // 0000_0100 = 4
    Pokemon             = 1 << 3,   // 0000_1000 = 8
    MHRise              = 1 << 4,   // 0001_0000 = 16
    BanjoKazooie        = 1 << 5,   // 0010_0000 = 32
    Fifa                = 1 << 6,   // 0100_0000 = 64
    // 69 = fifa + mariokart64 + dst (64+4+1)
}
