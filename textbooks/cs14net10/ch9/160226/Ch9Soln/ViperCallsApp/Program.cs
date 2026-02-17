using TPNS.SharedLibrary;


Console.WriteLine("Hello Viper Calls App\n");

string curr_dir = CurrentDirectory;
string viper_txt_path = Combine(curr_dir,"viper.txt");

WriteLine("Writing to: {0}",viper_txt_path);


using var txt_stream_obj = File.CreateText(viper_txt_path);
foreach (string calls_signs in Viper.CallSigns)
{
    WriteLine(calls_signs);
    txt_stream_obj.WriteLine(calls_signs);
}

WriteLine("\nProgram Ended");




