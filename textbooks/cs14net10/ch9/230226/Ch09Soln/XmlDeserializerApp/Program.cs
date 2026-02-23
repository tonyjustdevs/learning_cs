using System.ComponentModel;
using System.Xml.Serialization; // To use XmlSerializer.
using Packt.Shared; // To use Person.

// create serialiser
List<Person> ppl  = new();
XmlSerializer xs = new(ppl.GetType());
string full_path = Combine(GetCurrentDirectory(), "serials_business.xml");
using  (FileStream fs = File.Open(full_path,FileMode.Open))
{
    List<Person>? ppl_list_object = xs.Deserialize(fs) as List<Person>;
	if (ppl_list_object is not null)
    {
		foreach (Person? p in ppl_list_object)
		{
			WriteLine($"{p.LastName} has {p.Children.Count} children");
		} 

	}
}

