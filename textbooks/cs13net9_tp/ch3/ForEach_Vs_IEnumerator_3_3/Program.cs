//// v1: foreach
//string[] names = { "mate", "ange", "mourinho", "pep" };
//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}


// v2: IEnumerator
//using System.Collections;
using System.Collections;
Console.WriteLine();
string[] names = { "mate", "ange", "mourinho", "pep" };
IEnumerator name_rator= names.GetEnumerator();
while (name_rator.MoveNext())
{
    //Console.WriteLine($"name_rator.Current: {name_rator.Current}, type: {name_rator.Current.GetType()}");
    Console.WriteLine($"name_rator.Current: {(int)name_rator.Current}");
}

// foreach: any type following rules:
// The type has methido [GetEnumerator()] => returns an object.
// Return object has
//  - .property  [.Current]
//  - .method(): [MoveNext()]
//      -   MoveNext()
//      -   RETURNS [true]:     chgs value of Current [if more items] or
//      -   RETURNS [false]:    [if no more items].
