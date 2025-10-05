int x = 10;

int y = 6;
const int width = 7;
WriteLine($"Bitwise Ops | Decimal | Binary   | Exp_Dec | Exp_Bin     |");
WriteLine($"  x         | {x,width} | {x:B8} | [10]    | [0000-1010] |");
WriteLine($"  y         | {y,width} | {y:B8} | [6]     | [0000-0110] |");
WriteLine($"x&y         | {x&y,width} | {x&y:B8} | [2]     | [0000-0010] |");
WriteLine($"x|y         | {x|y,width} | {x|y:B8} | [14]    | [0000-1110] |");
WriteLine($"x^y         | {x^y,width} | {x^y:B8} | [12]    | [0000-1100] |");

WriteLine();
WriteLine($"BinShift Ops| Decimal | Binary   | Exp_Dec | Exp_Bin     |");
WriteLine($"x << 3      | {x << 3,7} | {x << 3:B8} | [80]    | [0101-0000] |");    // 0000-1010 (10)   <<3  -> 0101-0000 (16+64=80): Left-shift x by 3 bit columns.
WriteLine($"x * 8       | {x * 8,7} | {x * 8:B8} | [80]    | [0101-0000] |");       // 0101-0000 (10*8): Multiply x by 8.
WriteLine($"y >> 1      | {y >> 1,7} | {y >> 1:B8} | [3]     | [0000-0011] |");        // 0000-0110 (6)    >>1  -> 0000-0011 (1+2=3): Right-shift y by 1 bit column.
