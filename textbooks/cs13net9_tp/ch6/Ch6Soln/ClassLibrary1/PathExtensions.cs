using System.IO.IsolatedStorage;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace TP.SharedLibraries;

public static class PathExtensions 
{
    public static bool IsFileOG(string input_path) {          // v1. PathExtensions.mth()
        Console.WriteLine($"Running PathExtensions.IsFile() for:\n\t'{input_path}' [PathExtensions.IsFileOG()]");
        return false; 
    }
    public static bool IsFile(this string? input_path)
    {          
        Console.WriteLine($"Running PathExtensions.IsFile() for:\n\t'{input_path}' [PathExtensions.IsFile()]");
        return false;
    }

}

//public static class PathExt
//{
//    public static 
//}


