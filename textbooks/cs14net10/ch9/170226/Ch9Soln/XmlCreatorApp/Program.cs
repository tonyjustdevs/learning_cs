using System.Xml;
using TPNS.SharedLibrary;
//using TPNS.SharedLibrary;

Console.WriteLine("Welcome to XmlCreatorApp!\n");
string curr_dir = CurrentDirectory;
string xml_file_path = Combine(curr_dir, "viper.xml");        //  [2A-OK]
//while (File.Exists(xml_file_path))
//{
//    WriteLine($"Does {xml_file_path} exist? {File.Exists(xml_file_path)}\nPress any key to continue...\n");
//    ReadKey(intercept: true);
//    File.Delete(xml_file_path);
//    WriteLine($"Deleted existing file: {GetFileName(xml_file_path)}\nPress any key to continue...\n");
//    ReadKey(intercept: true);
//    WriteLine($"Does {xml_file_path} exist? {File.Exists(xml_file_path)}\nPress any key to continue...\n");
//    ReadKey(intercept: true);
//} // ----------- this is redundant because [File.Create] overrides any existing file ----------- 

FileStream? xml_fstream = File.Create(xml_file_path);
//var xml_fstream2 = File.OpenWrite(xml_file_path);
//FileStream? xml_fstream = File.Create(xml_file_path);
//ReadKey(intercept: true);

XmlWriterSettings xml_settings = new() { Indent = true };
XmlWriter? xmlwriter_obj = XmlWriter.Create(xml_fstream, xml_settings);
//XmlWriter? xmlwriter_obj = null;

try
{
    // assuming xmlwriter is not null:
    xmlwriter_obj.WriteStartDocument();
    xmlwriter_obj.WriteStartElement("TOP_LVL_ELEMENT");
    foreach (var current_call_sign in Viper.CallSigns)
    {
        xmlwriter_obj.WriteElementString("L1_ELEMENT",current_call_sign);
    }
    xmlwriter_obj.WriteEndElement();
    //xmlwriter_obj.WriteEndDocument();
    //xmlwriter_obj.WriteElementString("SOME_TOP_LEVEL_ELEMENT","mate1");
    //xmlwriter_obj.WriteElementString("SOME_TOP_LEVEL_ELEMENT","mate2");
    //xmlwriter_obj.WriteElementString("SOME_TOP_LEVEL_ELEMENT","mate3");
}
catch (Exception e)
{
    WriteLine($"[ATTENTION] ------ ERROR CAUGHT BY DEV ------ ");
    WriteLine($"----------------------------------------------");
    WriteLine($"{e}");
    WriteLine($"----------------------------------------------");
    WriteLine($"[ATTENTION] ------ ERROR COMPLETE BY DEV ------ \n");
}
finally
{
    if (xmlwriter_obj is not null)
    {
        xmlwriter_obj.Dispose();
    }
	if (xml_fstream is not null)
	{
		xml_fstream.Dispose();
    }
}
WriteLine("\nprogram ending succesfully...");