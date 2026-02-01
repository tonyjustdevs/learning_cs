
namespace TPNS.TPSharedLibNet2;

public enum EnumCountrys
{
    Vietnam,
    Australia,
    England,
    USA,
    China,
    Greenland,
    Japan
}

[Flags]
public enum EnumByteCountrys : byte
{
    Vietnam         = 0b_0000_0001,     // 1 
    Australia       = 0b_0000_0010,     // 2 
    England         = 0b_0000_0100,     // 4
    USA             = 0b_0000_1000,     // 8
    China           = 0b_0001_0000,     // 16
    Greenland       = 0b_0010_0000,     // 32
    Japan           = 0b_0100_0000,     // 64
    Indonesia       = 0b_1000_0000      // 128
}
