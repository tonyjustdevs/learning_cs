int x = 10;

int y = 6;
const int width = 7;
WriteLine($"Expression  | Decimal | Binary   | Exp_Dec | Exp_Bin     |");
WriteLine($"  x:        | {x,width} | {x:B8} | [10]    | [0000-1010] |");
WriteLine($"  y:        | {y,width} | {y:B8} | [6]     | [0000-0110] |");
WriteLine($"x&y:        | {x&y,width} | {x&y:B8} | [2]     | [0000-0010] |");
WriteLine($"x|y:        | {x|y,width} | {x|y:B8} | [14]    | [0000-1110] |");
WriteLine($"x^y:        | {x^y,width} | {x^y:B8} | [12]    | [0000-1100] |");
