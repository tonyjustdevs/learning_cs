using System.IO.IsolatedStorage;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace TP.SharedLibraries;
public static class PathExtensions 
{
    public static bool IsDirPE(this string input_path)
    {          
        Console.WriteLine($"Running PathExtensions.IsFile() for:\n\t'{input_path}' [PathExtensions.IsFile()]");
        return false;
    }
}
public static class PathExtensions2
{
    extension(Path)
    {
        public static bool? IsDirectoryPE2(string path)
        {
            if (Directory.Exists(path))
                return true;
            if (File.Exists(path))
                return false;
            return null;
        }
    }
}


