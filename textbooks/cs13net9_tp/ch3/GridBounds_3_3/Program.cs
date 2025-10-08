
// 1-dim arr

string[] names = new string[] { "aaaa", "bbbb", "cccc" };


// 2-d arr
string[,] names_grid = new string[,] {
    { "aaaa", "bbbb", "cccc"},
    { "aa", "bb", "cc"},
    { "aaa", "bbb", "ccc"},
    { "aaasda", "bbasdfb", "ccasdfc"},
};


Console.WriteLine($"names_grid.GetLowerBound(0): {names_grid.GetLowerBound(0)} (EXP: 0)");
Console.WriteLine($"names_grid.GetUpperBound(0): {names_grid.GetUpperBound(0)} (EXP: 3)");

Console.WriteLine($"names_grid.GetLowerBound(1): {names_grid.GetLowerBound(1)} (EXP: 0)");
Console.WriteLine($"names_grid.GetUpperBound(1): {names_grid.GetUpperBound(1)} (EXP: 2)");