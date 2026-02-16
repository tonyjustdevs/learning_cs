using TPNS.SharedLibrary;

Console.WriteLine("Welcome to ViperTextApp");

// filepath

string curr_dir = Directory.GetCurrentDirectory();
string viper_txt_path = Combine(curr_dir,"viper.txt");

// add file
var viper_stream = File.CreateText(viper_txt_path);

foreach (var viper in Viper.CallSigns)
{
    //WriteLine($"{viper}");
    viper_stream.WriteLine($"{viper}");
}
viper_stream.Close();


//OutputFileInfo(viper_txt_path);
OutputFileInfoLinebyLine(viper_txt_path);
//var viper_read_txt = File.ReadAllText(viper_txt_path);

//WriteLine($"File Name: {GetFileName(viper_txt_path)}");
//WriteLine($"Dir Name: {GetDirectoryName(viper_txt_path)}");
//WriteLine($"Contents:\n/------------------------\n");
//WriteLine(viper_read_txt);
//WriteLine($"------------------------/");




