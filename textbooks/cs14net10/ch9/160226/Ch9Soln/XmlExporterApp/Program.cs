using System.Xml;
using TPNS.SharedLibrary;
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

xml.WriteStartElement("LEVEL1");


xml.WriteElementString("LEVEL2","bro1");
xml.WriteStartElement("LEVEL3");
xml.WriteElementString("LEVEL3-1", "YEAH3");
xml.WriteElementString("LEVEL3-1", "YEAH3");
xml.WriteEndElement();
xml.WriteElementString("LEVEL2", "bro2");
xml.WriteElementString("LEVEL2", "bro3");
xml.WriteEndElement();
//xml.WriteEndElement();

xml.Close();
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

