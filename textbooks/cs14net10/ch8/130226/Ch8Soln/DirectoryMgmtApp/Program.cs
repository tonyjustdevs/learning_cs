using Microsoft.VisualBasic.FileIO;
using Spectre.Console;

Console.WriteLine("Hello File-Mgt-App!");

// create path
string newFolder = Path.Combine(GetFolderPath(SpecialFolder.Personal), "TPDirMgmtApp");

// check path.exists
WriteLine("\ndoes '{0}' exist? \n{1}", newFolder, Path.Exists(newFolder));
ReadKey(intercept: true);
// create dir
WriteLine("Adding new dir: '{0}'", newFolder);
var newFolderObj = CreateDirectory(newFolder);
WriteLine("\ndoes '{0}' exist? \n{1}", newFolder, Path.Exists(newFolder));
ReadKey(intercept: true);

//WriteLine($"\nnewFolderObj.Name: {newFolderObj.Name}");
//WriteLine($"\nnewFolderObj.FName: {newFolderObj.FullName}");
//WriteLine($"\nnewFolderObj.Parent: {newFolderObj.Parent}");
//WriteLine($"\nnewFolderObj.GetType(): {newFolderObj.GetType()}");
// create dir.exists
WriteLine("Deleting Directory: '{0}'", newFolder);
Delete(newFolder, recursive:true);
WriteLine("\ndoes '{0}' exist? \n{1}", newFolder, Path.Exists(newFolder));
ReadKey(intercept: true);



// delete path

WriteLine("End of Progarm");
ReadKey(intercept: true);