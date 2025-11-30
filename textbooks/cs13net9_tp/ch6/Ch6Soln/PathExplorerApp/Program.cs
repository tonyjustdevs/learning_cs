using System.IO;

Console.WriteLine("Hello PathExplorerApp!!");

// 1. create a full path
// eg. string full = Path.Combine("C:\\Users", "mate", "Documents", "file.txt");
//C: \Users\tonyp\learn\csharp\textbooks\cs13net9_tp\ch6
string full_path = Path.Combine("C:\\Users", "tonyp", "learn", "csharp", "textbooks","cs13net9_tp","ch6", "TextFile1.txt");
Console.WriteLine($"full_path.ToString(): \t\t\t{full_path.ToString()}");
Console.WriteLine($"Path.GetFileName(full_path): \t\t{Path.GetFileName(full_path)}");
Console.WriteLine($"Path.GetFileNameWoutExt(full_path): \t{Path.GetFileNameWithoutExtension(full_path)}");
Console.WriteLine($"Path.GetExtension(full_path): \t\t{Path.GetExtension(full_path)}");
Console.WriteLine($"Path.GetDirectoryName(full_path): \t{Path.GetDirectoryName(full_path)}");
Console.WriteLine("Path.ChangeExtension(full_path, ''md''): {0}", Path.ChangeExtension(full_path, "md"));
Console.WriteLine("Path.GetFullPath(full_path): {0}", Path.GetFullPath(full_path));

string _tmpfile1 = Path.GetTempFileName();
string _tmpfile2 = Path.GetTempFileName();
string _tmpfld1 = Path.GetTempPath();
string _tmpfld2 = Path.GetTempPath();
Console.WriteLine($"Path.GetTempFileName()_1: {_tmpfile1}");
Console.WriteLine($"Path.GetTempFileName()_2: {_tmpfile2}");
Console.WriteLine($"Path.GetTempPath()_1: {_tmpfld1}");
Console.WriteLine($"Path.GetTempPath()_2: {_tmpfld2}");
// egs

// create rndm path
//get
//{
//    var path = Path.Combine(Path.GetTempPath(), "LiteDbExplorer");
//if (!Directory.Exists(path))
//{
//    Directory.CreateDirectory(path);
//}

//return path;
//}

// misc useful?
// 1. !Path.IsPathRooted(x)