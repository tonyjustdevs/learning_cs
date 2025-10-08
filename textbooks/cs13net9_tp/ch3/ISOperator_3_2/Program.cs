
//object o = "69";
object o = 69;
int j = 420;

if (o is int z)
{   // if o is int then apply arithmetic: o+z
    Console.WriteLine($"o is an integer (o[{o}]+j[{j}]): {z + j}");
    //Console.WriteLine($"o is an integer (o[{o}]+j[{j}]): {z + j}");
}
else
{
    Console.WriteLine($"{o} is not an integer!");
}