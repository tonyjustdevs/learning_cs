// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Xml;
using System.Xml.Serialization;
using TP.SharedLib;
using FastJson = System.Text.Json.JsonSerializer;
Console.WriteLine("Hello XMLDeserializerPeopleApp");


// GET xml
//string file_name = "serialized_people.xml";
//string full_path = Combine(GetCurrentDirectory(), file_name);

//// add stream
//XmlSerializer xs = new(new List<Person>().GetType());

//using (FileStream xml_stream = File.Open("serialized_people.xml", FileMode.Open)) { 
//List<Person>? deserialized_ppl = xs.Deserialize(xml_stream) as List<Person>;
//    if (deserialized_ppl is not null)
//    {
//        WriteLine($"Deserialization: {GetFileName(full_path)}");

//        foreach (var p in deserialized_ppl)
//        {
//            WriteLine($"{p.FullName} has {p.Children.Count} kid(s).");
//        }
//    }
//}
// json deserialiser
// GET .json
//file_name = "serialized_people.json";
//full_path = Combine(GetCurrentDirectory(), file_name);

//Newtonsoft.Json.JsonSerializer json_deserializer = new();

//using (var stream_reader = File.OpenText(full_path))
//{
//    using (JsonTextReader json_reader = new JsonTextReader(stream_reader)){

//        try
//        {
//            List<Person>? deserialized_people_json = json_deserializer.Deserialize<List<Person>>(json_reader);
//            //List<Person>? deserialized_people_json = json_deserializer.Deserialize(json_reader) as List<Person>;

//            WriteLine($"Deserialization: {GetFileName(full_path)}");

//            if (deserialized_people_json is null)
//            {
//                WriteLine("deserialized_people_json is null");
//                return;
//            }

//            foreach (var p in deserialized_people_json)
//            {
//                //WriteLine($"{p.FullName} has {p.Children.Count} kid(s).");
//            }
//        }
//        catch (Exception ex)
//        {
//            WriteLine($"ERROR OCCURED: [{ex}]");
//        }

//    }
//}
/// create file stream
/// 
string file_name = "serialized_people.json";
string full_path = Combine(GetCurrentDirectory(), file_name);
try
{
    using var stream = File.OpenRead(full_path);

    var people = FastJson.Deserialize<List<Person>>(stream)
                 ?? throw new InvalidOperationException("JSON returned null.");

    foreach (var p in people)
        WriteLine($"{p.FullName} has {p.Children.Count} kid(s).");
}
catch (Exception ex)
{
    WriteLine($"Error: {ex}");
}

//await using (FileStream jsonLoad = File.Open(full_path, FileMode.Open))
//{
//    // Deserialize object graph into a "List of Person".
//    List<Person>? loadedPeople =
//      await FastJson.DeserializeAsync(utf8Json: jsonLoad,
//        returnType: typeof(List<Person>)) as List<Person>;
//    if (loadedPeople is not null)
//    {
//        foreach (Person p in loadedPeople)
//        {
//            WriteLine("{0} has {1} children.",
//              p.FullName, p.Children?.Count ?? 0);
//        }
//    }
//}