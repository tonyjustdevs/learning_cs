

using Spectre.Console;
using System.Net.NetworkInformation;
Console.WriteLine("Hello FileStreamApp");
CoolerTitle("Handling cross-platform environments and filesystems");
Table table = new();
table.AddColumn("[blue]MEMBER[/]");
table.AddColumn("[blue]VALUE[/]");


table.AddRow("Pth.PathSeparator", Path.PathSeparator.ToString());
table.AddRow("Pth.GetTempPath", Path.GetTempPath());
table.AddRow("Pth.DirectorySeparatorChar", Path.DirectorySeparatorChar.ToString());
table.AddEmptyRow();
table.AddRow("Dir.GetCurrentDirectory", Directory.GetCurrentDirectory());
table.AddRow("Env.SystemDirectory", Environment.SystemDirectory);
table.AddRow("Env.CurrentDirectory", Environment.CurrentDirectory);
table.AddEmptyRow();
table.AddRow("GFP.SFld.System", GetFolderPath(SpecialFolder.System));
table.AddRow("GFP.SFld.ApplicationData", GetFolderPath(SpecialFolder.ApplicationData));
table.AddRow("GFP.SFld.Personal", GetFolderPath(SpecialFolder.Personal));
table.AddRow("GFP.SFld.MyDocuments", GetFolderPath(SpecialFolder.MyDocuments));
table.AddRow("GFP.SFld.History", GetFolderPath(SpecialFolder.History));


// Render the table to the console
AnsiConsole.Write(table);

Table tbl2 = new();
tbl2.AddColumn("[blue]NAME[/]");
tbl2.AddColumn("[blue]TYPE[/]");
tbl2.AddColumn("[blue]FORMAT[/]");

//tbl2.AddColumn("[blue]SIZE[/]");
tbl2.AddColumn(new TableColumn("[blue]SIZE[/]").RightAligned());
//tbl2.AddColumn("[blue]FREE[/]");
tbl2.AddColumn(new TableColumn("[blue]FREE[/]").RightAligned());

foreach (var drive in DriveInfo.GetDrives())
{
	if (drive.IsReady)
	{
		tbl2.AddRow(drive.Name, drive.DriveType.ToString(), 
			drive.DriveFormat, drive.TotalSize.ToString("N0"), drive.AvailableFreeSpace.ToString("N0"));
	} else
	{
        tbl2.AddRow(drive.Name, drive.DriveType.ToString(),
            string.Empty, string.Empty, string.Empty);

    }
}

//AnsiConsole.Write(tbl2);


Table tbl3 = new();
tbl3.AddColumn("[blue]NAME[/]");
tbl3.AddColumn("[blue]TYPE[/]");
tbl3.AddColumn("[blue]FORMAT[/]");
tbl3.AddColumn("[blue]SIZE[/]");
tbl3.AddColumn("[blue]FREE[/]");


foreach (var drive in DriveInfo.GetDrives())
{
	if (drive.IsReady)
	{
		tbl3.AddRow(drive.Name, drive.DriveType.ToString(), drive.DriveFormat,
			drive.TotalSize.ToString("N0"),
			drive.TotalFreeSpace.ToString("N0"));
	}
}

AnsiConsole.Write(tbl3);
