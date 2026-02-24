
// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using TP.SharedLib;

Console.WriteLine("Hello, World!");

// create some people
var jason_bourne = new Person{FullName="Jason Bourne",DobOfBirth=new DateTimeOffset(1980,1,1,0,0,0,TimeSpan.Zero)};
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

// show file info
ShowFileInfo(xml_full_path);


static void ShowFileInfo(string full_path)
{
    WriteLine($"File: \t{GetFileName(full_path)}");
    WriteLine($"Dir: \t{GetDirectoryName(full_path)}");
    WriteLine($"Size: \t{new FileInfo(full_path).Length:N0} bytes");
    WriteLine($"Contents: ");
    WriteLine($"/ ----------------------------- /");
    //WriteLine($"{File.ReadAllLines(full_path)}");
    var string_list = File.ReadAllLines(full_path);
    foreach (var line in string_list)
    {
        WriteLine(line);
    }
    //WriteLine($"{File.ReadAllLines(full_path)}");
    //WriteLine($"{File.ReadAllText(full_path)}");
    WriteLine($"/ ----------------------------- /");
    
}

