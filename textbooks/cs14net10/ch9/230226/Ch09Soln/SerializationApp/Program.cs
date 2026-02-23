using System.Xml.Serialization; // To use XmlSerializer.
using Packt.Shared; // To use Person.

List<Person> people = new()
{
  new(initialSalary: 30_000M)
  {
    FirstName = "Alice",
    LastName = "Smith",
    DateOfBirth = new(year: 1974, month: 3, day: 14)
  },
  new(initialSalary: 40_000M)
  {
    FirstName = "Bob",
    LastName = "Jones",
    DateOfBirth = new(year: 1969, month: 11, day: 23)
  },
  new(initialSalary: 20_000M)
  {
    FirstName = "Charlie",
    LastName = "Cox",
    DateOfBirth = new(year: 1984, month: 5, day: 4),
    Children = new()
    {
      new(initialSalary: 0M)
      {
        FirstName = "Sally",
        LastName = "Cox",
        DateOfBirth = new(year: 2012, month: 7, day: 12)
      }
    }
  }
};
//SectionTitle("Serializing as XML");
//// Create serializer to format a "List of Person" as XML.
//XmlSerializer xs = new(type: people.GetType());
//// Create a file to write to.
//string path = Combine(CurrentDirectory, "people.xml");
//using (FileStream stream = File.Create(path))
//{
//    // Serialize the object graph to the stream.
//    xs.Serialize(stream, people);
//} // Closes the stream.
DoSerialization(people, "cool_beans.xml");
SerializeOnceAgain(people,"serial_business.xml");
//OutputFileInfo(path);
GenerateFileInfo("serial_business.xml");
DoJsonSeralzsation(people, "serial.json");
TPJsonSerialisater(people, "TPserial.json");
//WriteLine($"people.GetType(): {people.GetType()}");
//WriteLine($"new Person(): {new Person().GetType()}");

