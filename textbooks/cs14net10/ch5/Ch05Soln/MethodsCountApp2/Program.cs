using System;
using System.Reflection;
Console.WriteLine("Hello to MethCounter2");

System.Data.DataSet ds = new();
HttpClient client = new();

// 1. get entry pt to assembly
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) { return; }

// 2. get reference asemblies
foreach (var ref_assembly_object in assembly.GetReferencedAssemblies())
{
    //Console.WriteLine($"ref_assembly_object.GetType(): {ref_assembly_object.GetType()}");
    // 3. load each assembly
    var loaded_a = Assembly.Load(ref_assembly_object);
    //Console.WriteLine($"\nloaded_a: {ref_assembly_object.Name}");

    // 4. get types
    // 4i. count types
    int no_of_meths = 0;
    int no_of_types = loaded_a.DefinedTypes.Count();
    foreach (TypeInfo a_type in loaded_a.DefinedTypes)
    {
        // 5.   get methods
        // 5i.  keep count of methods across types
        no_of_meths += a_type.GetMethods().Length;


    }
    Console.WriteLine($"[{no_of_types}] types has [{no_of_meths}] methods in [{ref_assembly_object.Name}]");
    //[0] types has[0] methods in [System.Runtime]
    //[413] types has[7194] methods in [System.Data.Common]
    //[435] types has[4772] methods in [System.Net.Http]
    //[44] types has[656] methods in [System.Console]
    //[119] types has[1491] methods in [System.Linq]
}


// 6. tally methods


