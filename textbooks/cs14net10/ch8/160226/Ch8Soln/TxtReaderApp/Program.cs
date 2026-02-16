Console.WriteLine("Hello TxtReaderApp");

// create directory path
string app_dir_path = Combine(GetFolderPath(SpecialFolder.Personal), "TonysApps", "FileCreateCopierApp");
string tonys_bak = "TonysText.bak";
string tonys_bak_path = Combine(app_dir_path, tonys_bak);


// check if dir exists
if (!Directory.Exists(app_dir_path))
{
    throw new ArgumentException("File Path not found!", app_dir_path);
}
WriteLine($"Locating: '{tonys_bak_path}'");

if (!File.Exists(tonys_bak_path))
{
    throw new ArgumentException("File Path not found!", tonys_bak_path);
}


if (File.Exists(tonys_bak_path))
{
    WriteLine("File Path found:", tonys_bak_path);
}

var tonys_read_txt =  File.OpenText(tonys_bak_path);

WriteLine($"tonys_read_txt:\n{tonys_read_txt.ReadToEnd()}");


FileInfo info = new(tonys_bak_path);
WriteLine($"info.LastAccessTime: {info.LastAccessTime}");
WriteLine($"info.IsReadOnly: {info.IsReadOnly}");
WriteLine($"info.Length: {info.Length}");

WriteLine("Program ended."); 