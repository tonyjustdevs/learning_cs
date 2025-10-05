

using System.Reflection;

string horizontalLine = new('-', count: 115); // 74 hyphens.
Console.WriteLine(horizontalLine);
const int wd =40;
unsafe {  
    Console.WriteLine($"{"Type",-10}{"Bytes(s) of Memory",-25}{"Min",wd}{"Max",wd}");
    Console.WriteLine($"{"byte",-10}{sizeof(byte),-25}{byte.MinValue,wd:E}{byte.MinValue,wd:E}");
    Console.WriteLine($"{"short",-10}{sizeof(short),-25} {short.MinValue,wd:E}{short.MinValue,wd:E}");
    Console.WriteLine($"{"ushort",-10}{sizeof(ushort),-25} {ushort.MinValue,wd:E}{ushort.MinValue,wd:E}");
    Console.WriteLine($"{"int",-10}{sizeof(int),-25} {int.MinValue,wd:E}{int.MinValue,wd:E}");
    Console.WriteLine($"{"uint",-10}{sizeof(uint),-25} {uint.MinValue,wd:E}{uint.MinValue,wd:E}");
    Console.WriteLine($"{"long",-10}{sizeof(long),-25} {long.MinValue,wd:E}{long.MinValue,wd:E}");
    Console.WriteLine($"{"ulong",-10}{sizeof(ulong),-25} {ulong.MinValue,wd:E}{ulong.MinValue,wd:E}");
    Console.WriteLine($"{"Int128",-10}{sizeof(Int128),-25} {Int128.MinValue,wd:E}{Int128.MinValue,wd:E}");
    Console.WriteLine($"{"UInt128",-10}{sizeof(UInt128),-25} {UInt128.MinValue,wd:E}{UInt128.MinValue,wd:E}");
    Console.WriteLine($"{"Half",-10}{sizeof(Half),-25} {Half.MinValue,wd:E}{Half.MinValue,wd:E}");
    Console.WriteLine($"{"float",-10}{sizeof(float),-25} {float.MinValue,wd:E}{float.MinValue,wd:E}");
    Console.WriteLine($"{"double",-10}{sizeof(double),-25} {double.MinValue,wd:E}{double.MinValue,wd:E}");
    Console.WriteLine($"{"decimal",-10}{sizeof(decimal),-25} {decimal.MinValue,wd:E}{decimal.MinValue,wd:E}");
}


//type_list[] cool_list = [];

//Console.WriteLine($"{"sbyte",-10}{"1",-25}{"-1398127389127398127389127328", wd}{"18127389172398127327",wd}");






// -------------------------------------- MISSION --------------------------------------
// sbyte, byte, short, ushort, int, uint, long, ulong, Int128, UInt128, Half, float, double, and decimal
// Type,    Bytes(s) of Memory,     Min,    Max
// sbyte    1                       -128    127