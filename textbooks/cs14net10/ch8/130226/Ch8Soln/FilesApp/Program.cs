
Console.WriteLine("Hello, World!");


// [1] add paths
// - add path: directory
// - add path: file
// - add backup: bak
//Combine(SpecialFolder.Personal,)
string TonysFileAppDirectory = Combine(GetFolderPath(SpecialFolder.Personal), "TonysFileApp");
// [2] delete old shit
// - if dir exists: delete everything rcursively
if (Path.Exists(TonysFileAppDirectory))
{
    WriteLine("\nDoes directory {0}? {1}", TonysFileAppDirectory, Directory.Exists(TonysFileAppDirectory));
    WriteLine("Deleting existing {0}", TonysFileAppDirectory);
    Delete(TonysFileAppDirectory);
    WriteLine("Does directory {0}? {1}", TonysFileAppDirectory, Directory.Exists(TonysFileAppDirectory));
    WriteLine("Press Any Key to Continue..");
}
CreateDirectory(TonysFileAppDirectory);
WriteLine($"\nAdded directory: {TonysFileAppDirectory}");
string TonysFileAppName = "TonysFileApp.txt";
string BackupTonysFileAppName = "TonysFileApp.bak";


WriteLine("\nDoes directory {0}? {1}", TonysFileAppDirectory, Directory.Exists(TonysFileAppDirectory));
WriteLine("Deleting existing {0}", TonysFileAppDirectory);
Delete(TonysFileAppDirectory);
WriteLine("Does directory {0}? {1}", TonysFileAppDirectory, Directory.Exists(TonysFileAppDirectory));
WriteLine("Press Any Key to Continue..");
// [3] confirm file not existing:
// - confirm current file name
// - confirm current file existence

// [4] create file
// - add file
// - add sentence
// - close file


// [4] copy file
// - copy 
// - confirm existence: file, copy


// [4] delete files
// - delete
// - confirm non-existence: file, copy