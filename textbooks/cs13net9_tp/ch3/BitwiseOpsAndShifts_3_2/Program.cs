int x = 10;
int y = 6;

string[] headings = { "vars", "decimal", "binary","expected" };
char[] vars = { 'x', 'y' };

Console.WriteLine($"{headings[0],5}|{headings[1],8}|{headings[2],8}|{headings[3],9}");
Console.WriteLine($"{'x',5}|{      x,8}|{  x,8:B}|{"1010",9}");            
Console.WriteLine($"{'y',5}|{      y,8}|{  y,8:B}|{"110",9}");            

Console.WriteLine($"{("x&y"),5}|{x&y,8}|{x&y,8:B}|{"10",9}");    

Console.WriteLine($"{("x|y"),5}|{x|y,8}|{x|y,8:B}|{"1110",9}");    

Console.WriteLine($"{("x^y"),5}|{x^y,8}|{x^y,8:B}|{"1100",9}");    

//vars | decimal | binary
//    x | 10 | 1010
    //y | 6 | 110