
long some_long = 0b1_0000_0000_0000_0010; // 65538
short some_short = (short)some_long; // 2
// HEADINGS
Console.WriteLine("{0,12}{1,36:B32}{2,7}{3,36}", "Decimal", "Binary", "ExpDec","ExpBin");
Console.WriteLine("{0,12}{0,36:B32}{1,7}{2,36}", some_long, 65538, "00000000000000010000000000000010");
Console.WriteLine("{0,12}{0,36:B16}{1,7}{2,36}", some_short, 2,"0000000000000010");

//     Decimal                              Binary ExpDec                              ExpBin
//       65538    00000000000000010000000000000010  65538    00000000000000010000000000000010
//           2                    0000000000000010      2                    0000000000000010