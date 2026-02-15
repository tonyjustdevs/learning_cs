
Console.WriteLine("Welcome to DirsApp");

// create path

string new_folder_path = Path.Combine(GetFolderPath(SpecialFolder.MyDocuments), "tonytemp");

if (Path.Exists(new_folder_path))
{
    Delete(new_folder_path);
    WriteLine("{0} deleted", new_folder_path);
}
// check if path exists
WriteLine("Does {0} exist? \n{1}", new_folder_path, Path.Exists(new_folder_path));
ReadKey(intercept: true); 
var key_pressed = ReadKey();
WriteLine($"key pressed: {key_pressed}");

var fld_obj = CreateDirectory(new_folder_path);

WriteLine("Does {0} exist? \n{1}", new_folder_path, Path.Exists(new_folder_path));
ReadKey(intercept: true);

Delete(new_folder_path);
WriteLine("{0} deleted", new_folder_path);


WriteLine("fld_obj.CreationTimeUtc: {0}", fld_obj.CreationTimeUtc);