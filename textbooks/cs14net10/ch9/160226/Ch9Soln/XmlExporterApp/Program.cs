#define MY_FEATURE
using System.Xml;
using TPNS.SharedLibrary;


#if MY_FEATURE
Console.WriteLine("This runs only if MY_FEATURE is enabled.");
Console.WriteLine("Welcome to XMLExporterApp");

// add file path
var viper_file_path = Combine(CurrentDirectory, "viper.xml");

//StreamReader? stream=null;
XmlWriter? xml = null;
FileStream? viper_stream = null;
//using var xml = XmlWriter.Create(viper_file_path, new XmlWriterSettings() { Indent=true});
viper_stream =File.Create(viper_file_path);
xml = XmlWriter.Create(viper_stream, new XmlWriterSettings {Indent=true});
//xmlFileStream = File.Create(xmlFile);

xml.WriteStartDocument();
xml.WriteStartElement("callsigns");
foreach (string viper_call_sign in Viper.CallSigns)
{
    xml.WriteElementString("callsigns", viper_call_sign);
    WriteLine(viper_call_sign);
    
}
xml.WriteEndElement();

viper_stream.Close();
OutputFileInfo(viper_file_path);
//stream = File.OpenText(viper_file_path);
////stream()
//xml.GetHashCode()
//// read viper class
//foreach (var viper in Viper.CallSigns)
//{
//    WriteLine($"{viper}");
//}
//// add filestrem?
//// add xml stream?

#endif
