using System.Reflection;
Console.WriteLine("Hello MethodsCounter3");

// 1. get entry pt to assembly
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly is null) return;

// 2. get reference assemblies
var ref_assemblys = assembly.GetReferencedAssemblies();

// 2a. how many ref_assemblys are there? 2
//Console.Write($"Reference_Assemblies: ");
foreach (var ref_ass in ref_assemblys)
{
    //Console.Write($"'{ref_ass.Name}' ");
    Assembly loaded_ass = Assembly.Load(ref_ass); // 3a. Load each assembly
    //var type_list = loaded_ass.GetTypes();  // list of types - // 3b. For_each type -> get each method()
    var type_list = loaded_ass.DefinedTypes;  // list of types - // 3b. For_each type -> get each method()

    int no_of_meths = 0;                        // 3c. print each types (for each assembly)
    foreach (var type_obj in type_list)
    {
        //Console.WriteLine($"type_ob(getype): {type_obj} of {ref_ass.Name}"); working
        no_of_meths += type_obj.GetMethods().Length;
    }
    // 4a. Tally types // 4b. Tally methods
    Console.WriteLine("{0} has {1:N0} Types & {2:N0} Methods",
        ref_ass.Name,
        //type_list.Length,
        type_list.Count(),
        no_of_meths);
}
