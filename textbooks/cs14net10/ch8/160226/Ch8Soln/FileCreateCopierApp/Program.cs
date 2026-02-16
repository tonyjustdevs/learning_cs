// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello File Creator App");

// create directory path

string app_dir_path =Combine(GetFolderPath(SpecialFolder.Personal),"TonysApps","FileCreateCopierApp");
string tonys_txt = "TonysText.txt";
string tonys_bak = "TonysText.bak";

// create dir
CreateDirectory(app_dir_path);

// create files
string tonys_txt_path = Combine(app_dir_path, tonys_txt);
string tonys_bak_path = Combine(app_dir_path, tonys_bak);

var tonys_txt_stream = File.CreateText(Combine(app_dir_path, tonys_txt));
tonys_txt_stream.WriteLine("gday mate!");
tonys_txt_stream.Close();

// copy file
File.Copy(tonys_txt_path, tonys_bak_path, true);

//check if exists
if (File.Exists(tonys_txt_path))
{
    // deleting file
    WriteLine($"Does {tonys_txt_path} exist?\n{File.Exists(tonys_txt_path)}. Deleting file.");
    WriteLine($"Does {tonys_txt_path} exist? {File.Exists(tonys_txt_path)}");
}


WriteLine("Program ended.");