
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

    private static void OutputFileInfoLinebyLine(string txt_file_path)
    {
        // create the stream
        using var txt_stream = File.OpenText(txt_file_path);
        int line_no=0;
        while (!txt_stream.EndOfStream)
        {
            string? read_line = txt_stream.ReadLine();
            WriteLine($"{line_no}: {read_line}");
            line_no++;
        }
    }

}

