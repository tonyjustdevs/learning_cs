using System.Reflection;
Console.WriteLine("Hello to MethCounter2");


// 1. get entry pt to assembly
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) { return; }

// 2. get reference asemblies
foreach (var ref_assembly_object in assembly.GetReferencedAssemblies())
{
    //Console.WriteLine($"ref_assembly_object.GetType(): {ref_assembly_object.GetType()}");
// 3. load each assembly
    var loaded_a = Assembly.Load(ref_assembly_object);
    Console.WriteLine($"\nloaded_a: {ref_assembly_object.Name}");

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

    //loaded_a.DefinedTypes.ToList().ForEach( t => 
    //{
    //    var methods = t.GetMethods();
    //    Console.WriteLine($"Type: {t}, Methods Count: {methods.Length}");
    //});
}



// 6. tally methods


