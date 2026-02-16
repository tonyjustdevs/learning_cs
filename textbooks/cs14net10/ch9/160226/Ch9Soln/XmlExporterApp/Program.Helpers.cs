
using TPNS.SharedLibrary;

partial class Program
{
    private static void OutputFileInfo(string txt_file_path)
    {
        var viper_read_txt = File.ReadAllText(txt_file_path);

        WriteLine($"File Name: {GetFileName(txt_file_path)}");
        WriteLine($"Dir Name: {GetDirectoryName(txt_file_path)}");
        WriteLine($"File Size: {new FileInfo(txt_file_path).Length:N0}");
        WriteLine($"File Size: {new FileInfo(txt_file_path):N0}");
        WriteLine($"Contents:\n/------------------------\n");
        WriteLine(viper_read_txt);
        WriteLine($"------------------------/");
       }
}