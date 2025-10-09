// 0. import
using static System.Convert;

// 1. declare
double g_dbl = 9.8;
// 2. convert
int g_int = ToInt32(g_dbl);

// 3. print
Console.WriteLine($"g_dbl: {g_dbl}");
Console.WriteLine($"g_int: {g_int} (via ToInt32(g)");