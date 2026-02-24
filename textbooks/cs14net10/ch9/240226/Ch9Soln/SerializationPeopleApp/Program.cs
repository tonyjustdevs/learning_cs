

// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Serialization;
using TP.SharedLib;
using System.Text.Json; // To use JsonSerializerOptions.
using System.Text.Json.Schema; // To use JsonSchemaExporter.
Console.WriteLine("Hello, World!");

// create some people
var jason_bourne = new Person{FullName= "Jason Bourné", DobOfBirth=new DateTimeOffset(1980,1,1,0,0,0,TimeSpan.Zero)};
var leo_messi = new Person{FullName="Lionel Messi",DobOfBirth=new DateTimeOffset(1987,6,24,0,0,0,TimeSpan.Zero),
    Children = [
        new Person{FullName="kid1"},
        new Person{FullName="kid2"},
    ]
};
var shania_twain = new Person
{
    FullName = "Shania Twain",
    DobOfBirth = new DateTimeOffset(1965, 8, 28, 0, 0, 0, TimeSpan.Zero),
    Children = [new Person { FullName = "kiddo3" }]
};

List<Person> people = [jason_bourne, leo_messi, shania_twain];
// create serializer
XmlSerializer xs = new(people.GetType());

// create xml full path
string file_name = "serialized_people.xml";
string xml_full_path = Combine(GetCurrentDirectory(), file_name);
//using (StreamWriter swriter = File.CreateText(xml_full_path)) 
using (var xml_file_stream = File.Create(xml_full_path))
{
    xs.Serialize(xml_file_stream, people);
    WriteLine($"{file_name} has been xml-serialized.");
    
}

file_name = "serialized_people.json";
string json_full_path = Combine(GetCurrentDirectory(), file_name);

using (StreamWriter s_writer = new StreamWriter(json_full_path)) { 
    Newtonsoft.Json.JsonSerializer json_serializer = new();
    json_serializer.Serialize(s_writer, people);
}
// show file info


ShowFileInfo(xml_full_path);    // 1038 bytes
ShowFileInfo(json_full_path);   // 475 bytes


