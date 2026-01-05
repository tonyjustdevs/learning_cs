Console.WriteLine("Hello SizeExplorerApp1");
// two methods:
// 1. [operator]    sizeof()
// 2. [cls mbr]     MinValue, MaxValue

Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, min: {sbyte.MinValue}, min:{sbyte.MaxValue}");
Console.WriteLine($"byte: {sizeof(byte)} bytes, min: {byte.MinValue}, min:{byte.MaxValue}");
Console.WriteLine($"short: {sizeof(short)} bytes, min: {short.MinValue}, min:{short.MaxValue}");
Console.WriteLine($"ushort: {sizeof(ushort)} bytes, min: {ushort.MinValue}, min:{ushort.MaxValue}");
Console.WriteLine($"int: {sizeof(int)} bytes, min: {int.MinValue}, min:{int.MaxValue}");
Console.WriteLine($"uint: {sizeof(uint)} bytes, min: {uint.MinValue}, min:{uint.MaxValue}");
Console.WriteLine($"long: {sizeof(long)} bytes, min: {long.MinValue}, min:{long.MaxValue}");
Console.WriteLine($"ulong: {sizeof(ulong)} bytes, min: {ulong.MinValue}, min:{ulong.MaxValue}");

unsafe
{
    Console.WriteLine($"Int128: {sizeof(Int128)} bytes, min: {Int128.MinValue}, min:{Int128.MaxValue}");
    Console.WriteLine($"UInt128: {sizeof(UInt128)} bytes, min: {UInt128.MinValue}, min:{UInt128.MaxValue}");
    Console.WriteLine($"Half: {sizeof(Half)} bytes, min: {Half.MinValue}, min:{Half.MaxValue}");
}

Console.WriteLine($"float: {sizeof(float)} bytes, min: {float.MinValue}, min:{float.MaxValue}");
Console.WriteLine($"double: {sizeof(double)} bytes, min: {double.MinValue}, min:{double.MaxValue}");
Console.WriteLine($"decimal: {sizeof(decimal)} bytes, min: {decimal.MinValue}, min:{decimal.MaxValue}");

//string rowSeparator = new string('-', count: 104);
//WriteLine(rowSeparator);
//WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
//WriteLine(rowSeparator);
//WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,45} {sbyte.MaxValue,45}");
//WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,45} {byte.MaxValue,45}");
//WriteLine($"short   {sizeof(short),-4} {short.MinValue,45} {short.MaxValue,45}");
//WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,45} {ushort.MaxValue,45}");
//WriteLine($"int     {sizeof(int),-4} {int.MinValue,45} {int.MaxValue,45}");
//WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,45} {uint.MaxValue,45}");
//WriteLine($"long    {sizeof(long),-4} {long.MinValue,45} {long.MaxValue,45}");
//WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,45} {ulong.MaxValue,45}");
//unsafe
//{
//    WriteLine($"Int128  {sizeof(Int128),-4} {Int128.MinValue,45} {Int128.MaxValue,45}");
//    WriteLine($"UInt128 {sizeof(UInt128),-4} {UInt128.MinValue,45} {UInt128.MaxValue,45}");
//    WriteLine($"Half    {sizeof(Half),-4} {Half.MinValue,45} {Half.MaxValue,45}");
//}
//WriteLine($"float   {sizeof(float),-4} {float.MinValue,45} {float.MaxValue,45}");
//WriteLine($"double  {sizeof(double),-4} {double.MinValue,45} {double.MaxValue,45}");
//WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,45} {decimal.MaxValue,45}");
//WriteLine(rowSeparator);


//--------------------------------------------------------------------------------------------------------
//Type    Byte(s) of memory                              Min                                           Max
//--------------------------------------------------------------------------------------------------------
//sbyte   1                                             -128                                           127
//byte    1                                                0                                           255
//short   2                                           -32768                                         32767
//ushort  2                                                0                                         65535
//int     4                                      -2147483648                                    2147483647
//uint    4                                                0                                    4294967295
//long    8                             -9223372036854775808                           9223372036854775807
//ulong   8                                                0                          18446744073709551615
//Int128  16        -170141183460469231731687303715884105728       170141183460469231731687303715884105727
//UInt128 16                                               0       340282366920938463463374607431768211455
//Half    2                                           -65500                                         65500
//float   4                                   -3.4028235E+38                                 3.4028235E+38
//double  8                         -1.7976931348623157E+308                       1.7976931348623157E+308
//decimal 16                  -79228162514264337593543950335                 79228162514264337593543950335
//--------------------------------------------------------------------------------------------------------

//sbyte: 1 bytes, min: -128, min: 127
//byte: 1 bytes, min: 0, min: 255
//short: 2 bytes, min: -32768, min: 32767
//ushort: 2 bytes, min: 0, min: 65535
//int: 4 bytes, min: -2147483648, min: 2147483647
//uint: 4 bytes, min: 0, min: 4294967295
//long: 8 bytes, min: -9223372036854775808, min: 9223372036854775807
//ulong: 8 bytes, min: 0, min: 18446744073709551615
//Int128: 16 bytes, min: -170141183460469231731687303715884105728, min: 170141183460469231731687303715884105727
//UInt128: 16 bytes, min: 0, min: 340282366920938463463374607431768211455
//Half: 2 bytes, min: -65500, min: 65500
//float: 4 bytes, min: -3.4028235E+38, min: 3.4028235E+38
//double: 8 bytes, min: -1.7976931348623157E+308, min: 1.7976931348623157E+308
//decimal: 16 bytes, min: -79228162514264337593543950335, min: 79228162514264337593543950335