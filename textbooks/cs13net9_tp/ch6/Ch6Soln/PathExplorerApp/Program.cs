using TP.SharedLibraries;
using System.IO;
Console.WriteLine("Hello PathExplorerApp!!");

// 1. create a full path
// eg. string full = Path.Combine("C:\\Users", "mate", "Documents", "file.txt");
//C: \Users\tonyp\learn\csharp\textbooks\cs13net9_tp\ch6
string full_path = Path.Combine("C:\\Users", "tonyp", "learn", "csharp", "textbooks","cs13net9_tp","ch6", "TextFile1.txt");
string full_path2 = Path.Combine("C:\\Users", "tonyp", "learn", "csharp", "textbooks","cs13net9_tp","ch6", "TextFile2.txt");
Console.WriteLine("Path Combine Result: {0}", full_path);
Console.WriteLine("Path Combine Result: {0}", full_path2);

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

// 1  check directory exists
// existing files: C: \Users\tonyp\learn\csharp\textbooks\cs13net9_tp\ch6\TextFile1.txt
//
string base_dir     = @"C:\Users\tonyp\learn\csharp\textbooks\cs13net9_tp\ch6\Ch6Soln\PathExplorerApp\";
string file_nm      = "TextFile1.txt";
string file_path    = Path.Combine(base_dir, file_nm);
//Directory.Exists();
Console.WriteLine("\nPart 2\n");
Console.WriteLine("Checking existence of '{0}': {1}",base_dir, Directory.Exists(base_dir));
Console.WriteLine("Checking existence of '{0}': {1}",file_path, File.Exists(file_path));

Car3 ford = new() { CountryOfOrigin = "USA", Model = "Ford", Year = 2000 };
Console.WriteLine();
CarExt.CarExt_IsAmerican(ford);

CarExt2.IsVeryOldStatic(ford);

ford.IsVeryOldInstce();

ford.IsVeryOldInstceViaExtensionBlocks();

ford.IsVeryOldInstceViaExtensionBlocks(2012);



// TODO:

Console.WriteLine("\nPathExtensions Scenarios:\n");
//PathExtensions.IsFileOG(file_path);                             // v1: static extension method
//Path.IsFile(file_path);       
// v2: instance extension method, Path is not instantiated
//PathExtensions.Is
//Path.IsPathRooted(file_path);

Path.IsDirectoryPE2(file_path);