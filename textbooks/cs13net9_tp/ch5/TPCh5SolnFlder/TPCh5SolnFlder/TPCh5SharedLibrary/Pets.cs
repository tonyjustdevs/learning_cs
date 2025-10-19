namespace TPCh5SharedLibrary;

[Flags]
public enum Pets:byte
{
    None    = 0b_0000_0000, // 0
    Cat     = 0b_0000_0001, // 1
    Dog     = 0b_0000_0010, // 2
    Rabbit  = 0b_0000_0100, // 4
    Snake   = 0b_0000_1000, // 8
}                           // 15
