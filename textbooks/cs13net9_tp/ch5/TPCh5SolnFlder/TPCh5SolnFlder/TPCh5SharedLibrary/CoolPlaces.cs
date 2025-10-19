
namespace TPCh5SharedLibrary;

[Flags]
public enum CoolPlaces:byte
{
    Africa      = 0b_0000_0001, // 1
    Brazil      = 0b_0000_0010, // 2
    China       = 0b_0000_0100, // 4
    France      = 0b_0000_1000, // 8
    HongKong    = 0b_0001_0000, // 16
    London      = 0b_0010_0000, // 32
    NewYork     = 0b_0100_0000, // 64
    Zambia      = 0b_1000_0000  // 128
}                               
