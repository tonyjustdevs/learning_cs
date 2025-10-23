namespace TP.SharedNamespace;

public enum CountryEnum
{
    Australia,  // 0
    Vietnam,    // 1
    USA,        // 2
    UK,         // 3
    China,      // 4
    Singapore,  // 5
    Argentina   // 6
}

[Flags]
public enum CountryEnumByte : byte
{
    Australia   = 0,      //  0
    Vietnam     = 1 << 0, //  1
    USA         = 1 << 1, //  2
    UK          = 1 << 2, //  4     
    China       = 1 << 3, //  8  
    Singapore   = 1 << 4, // 16
    Argentina   = 1 << 5, // 32
    Madagascar  = 1 << 6  // 64
}
