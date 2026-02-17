// See https://aka.ms/new-console-template for more information
//#define TESTMODE

using System.Xml.Schema;
using TPNS.SharedLibrary;

Console.WriteLine("Hello, World!");

foreach (var call_signs in Viper.CallSigns)
{
    //write
    WriteLine(call_signs);

}
// [1] create template to add new folders
string curr_dir = CurrentDirectory;

// [2] create path (per call sign)
//string curr_call_path = Combine(curr_dir, "test_call_sign"); // ok
string curr_call_path = Combine(curr_dir, "test_call_sign"); // ok
CreateDirectory(curr_call_path);

// [3] test directory exists
#if TESTMODE
if (!Directory.Exists(curr_call_path))
{
    throw new ArgumentException("Folder not created!",nameof(curr_call_path));
}

if (Directory.Exists(curr_call_path))
{
    WriteLine($"Folder created succesfully: {curr_call_path}");
}
#endif
// [4]
