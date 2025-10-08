
string[] names;
names               = new string[4];
names[0] = "aaa";
names[1] = "bbb";
names[3] = "ccc";

string[] names2     = new string[] { "mate", "ange", "cuz", "yolo" };
var names3  = new string[] { "aaaa", "bbbb", "cccc", "dddd" };
var names4 = new[] { "aa", "bb", "cc", "dd" };
string[] names5 = [ "aaaa", "bbbbb", "ccccc", "ddddd" ];


foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.WriteLine();

foreach (var item in names2)
{
    Console.WriteLine(item);

}
Console.WriteLine();
foreach (var item in names3)
{
    Console.WriteLine(item);

}
Console.WriteLine();
foreach (var item in names4)
{
    Console.WriteLine(item);
}

Console.WriteLine();
foreach (var item in names5)
{
    Console.WriteLine(item);
}