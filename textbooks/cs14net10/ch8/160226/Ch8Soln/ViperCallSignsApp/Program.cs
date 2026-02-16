using System.IO;
using TPNS.SharedLibrary;
Console.WriteLine("Hello ViperCallSignsApp");

string curr_dir = Directory.GetCurrentDirectory();
WriteLine($"curr_dir: {curr_dir}");

string viper_txt_path = Combine(curr_dir, "viper.txt");

var viper_stream = File.CreateText(viper_txt_path);
foreach (var viper in Viper.ViperCallSigns)
{
    viper_stream.WriteLine(viper);
    //WriteLine($"Writing '{viper}'");
    //ReadKey(intercept: true);

}
viper_stream.Close();

// pretend read file: viper_txt_path
//WriteLine("file info tmp:\n");
WriteLine("**** File Info ****");
Console.WriteLine("dir: GetDirectoryName(viper_txt_path): {0}", GetDirectoryName(viper_txt_path));
Console.WriteLine("file: GetFileName(viper_txt_path): {0}", GetFileName(viper_txt_path));
Console.WriteLine($"size: FileInfo(viper_txt_path).Length(): {new FileInfo(viper_txt_path).Length:N0}");
WriteLine("/------------------");
WriteLine($"{File.ReadAllText(viper_txt_path)}");
WriteLine("------------------/");


//viper_txt_path.getdi