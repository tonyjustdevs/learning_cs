// See https://aka.ms/new-console-template for more information
using System.Xml;
using System.Xml.Serialization;
using TP.SharedLib;

Console.WriteLine("Hello XMLDeserializerPeopleApp");


// GET XML
string file_name = "serialized_people.xml";
string full_path = Combine(GetCurrentDirectory(), file_name);

// add stream
XmlSerializer xs = new(new List<Person>().GetType());
FileStream xml_stream = File.Open("serialized_people.xml",FileMode.Open);
List<Person> deserialized_ppl = xs.Deserialize(xml_stream) as List<Person>;
if (deserialized_ppl is not null)
{
    foreach (var p in deserialized_ppl)
    {
        WriteLine($"{p.FullName} has {p.Children.Count} kid(s).");
    }
}

// import data