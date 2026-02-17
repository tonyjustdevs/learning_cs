// See https://aka.ms/new-console-template for more information
//#define TESTMODE

using System.Xml.Schema;
using TPNS.SharedLibrary;

Console.WriteLine("Hello, World!");

string curr_dir = CurrentDirectory;
// [1] create template to add new folders

// [2A] create path (per call sign)                                 //  [2A-OK] [SINGLE FOLDER] 
//string curr_call_path = Combine(curr_dir, "test_call_sign");        //  [2A-OK]
//CreateDirectory(curr_call_path);                                    //  [2A-OK]

// [2b] create mutiple paths (per call sign)                        //  [2B] [MULTI-FOLDERS] 
string curr_call_path;
foreach (var call_signs in Viper.CallSigns)
{
    curr_call_path = Combine(curr_dir, call_signs);                 //  [2B] OK
    CreateDirectory(curr_call_path);                                //  [2B]
} 

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

WriteLine("\nprogram ended...\n");
// [4]
