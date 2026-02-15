//using Spectre.Console; // To use Table.
//#region Handling cross-platform environments and filesystems
//CoolTitle("Handling cross-platform environments and filesystems");
//// Create a Spectre Console table.
//Table table = new();
//// Add two columns with markup for colors.
//table.AddColumn("[blue]MEMBER[/]");
//table.AddColumn("[blue]VALUE[/]");
//// Add rows.
//table.AddRow("Path.PathSeparator", PathSeparator.ToString());
//table.AddRow("Path.DirectorySeparatorChar",
//  DirectorySeparatorChar.ToString());
//table.AddRow("Directory.GetCurrentDirectory()",
//  GetCurrentDirectory());
//table.AddRow("Environment.CurrentDirectory", CurrentDirectory);
//table.AddRow("Environment.SystemDirectory", SystemDirectory);
//table.AddRow("Path.GetTempPath()", GetTempPath());
//table.AddRow("");
//table.AddRow("GetFolderPath(SpecialFolder", "");
//table.AddRow(" .System)", GetFolderPath(SpecialFolder.System));
//table.AddRow(" .ApplicationData)",
//  GetFolderPath(SpecialFolder.ApplicationData));
//table.AddRow(" .MyDocuments)",
//  GetFolderPath(SpecialFolder.MyDocuments));
//table.AddRow(" .Personal)",
//  GetFolderPath(SpecialFolder.Personal));
//// Render the table to the console
//AnsiConsole.Write(table);
//#endregion


//SectionTitle("Managing drives");
//Table drives = new();
//drives.AddColumn("[blue]NAME[/]");
//drives.AddColumn("[blue]TYPE[/]");
//drives.AddColumn("[blue]FORMAT[/]");
//drives.AddColumn(new TableColumn(
//  "[blue]SIZE (BYTES)[/]").RightAligned());
//drives.AddColumn(new TableColumn(
//  "[blue]FREE SPACE[/]").RightAligned());
//foreach (DriveInfo drive in DriveInfo.GetDrives())
//{
//    if (drive.IsReady)
//    {
//        drives.AddRow(drive.Name, drive.DriveType.ToString(),
//          drive.DriveFormat, drive.TotalSize.ToString("N0"),
//          drive.AvailableFreeSpace.ToString("N0"));
//    }
//    else
//    {
//        drives.AddRow(drive.Name, drive.DriveType.ToString(),
//          string.Empty, string.Empty, string.Empty);
//    }
//}
//AnsiConsole.Write(drives);


//CoolTitle("Managing directories");
//string newFolder = Combine(
//  GetFolderPath(SpecialFolder.Personal), "NewFolder");
//WriteLine($"Working with: {newFolder}");
//// We must explicitly say which Exists method to use
//// because we statically imported both Path and Directory.
//WriteLine($"Does it exist? {Path.Exists(newFolder)}");
//WriteLine("Creating it...");
//CreateDirectory(newFolder);
//// Let's use the Directory.Exists method this time.
//WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
//Write("Confirm the directory exists, and then press any key.");
//ReadKey(intercept: true);
//WriteLine();
//WriteLine("Deleting it...");
//Delete(newFolder, recursive: true);
//WriteLine($"Does it exist? {Path.Exists(newFolder)}");

using Spectre.Console;

Table table = new();
table.AddColumn("[red]MBR[/]");
table.AddColumn("[red]VAL[/]");

//table.AddRow("Path.PathSeparator", Path.PathSeparator);

//table.AddRow("Path.PathSeparator: ", Path.PathSeparator);   