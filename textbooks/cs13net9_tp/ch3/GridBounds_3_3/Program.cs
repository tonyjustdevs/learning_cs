
// 1-dim arr

string[] names = new string[] { "aaaa", "bbbb", "cccc" };


// 2-d arr
string[,] names_grid = new string[,] {
    { "aaaa", "bbbb", "cccc"},
    { "aa", "bb", "cc"},
    { "aaa", "bbb", "ccc"},
    { "aaasda", "bbasdfb", "ccasdfc"},
};

//[0, 0]: aaaa
//[0, 1]: aa
//[0, 2]: aaa
//[1, 0]: bbbb
//[1, 1]: bb
//[1, 2]: bbb


Console.WriteLine($"names_grid.GetLowerBound(0): {names_grid.GetLowerBound(0)} (EXP: 0)");
Console.WriteLine($"names_grid.GetUpperBound(0): {names_grid.GetUpperBound(0)} (EXP: 3)");

Console.WriteLine($"names_grid.GetLowerBound(1): {names_grid.GetLowerBound(1)} (EXP: 0)");
Console.WriteLine($"names_grid.GetUpperBound(1): {names_grid.GetUpperBound(1)} (EXP: 2)");


// loop through grid with lbounds & ubounds

for (int row = 0; row <= names_grid.GetUpperBound(0); row++)
{
    for (int col = 0; col <= names_grid.GetUpperBound(1); col++)
    {
        Console.WriteLine($"[{row},{col}]: {names_grid[row,col]}");
    }
}












