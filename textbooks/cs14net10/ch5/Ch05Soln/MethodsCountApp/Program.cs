//using System.Reflection;
//using System.Text.RegularExpressions;
//Console.WriteLine("Hello MethodsCountApp!");

//// get entry pt to assembly
////Assembly assembly_entry_pt = Assembly.GetEntryAssembly()!; 
//Assembly? assembly_entry_pt = Assembly.GetEntryAssembly();

//if (assembly_entry_pt == null) { return; }

////Assembly? assembly = Assembly.GetEntryAssembly(); // tells compiler ass is not null
//var ass_list = assembly_entry_pt.GetReferencedAssemblies();

//foreach (var nice_ass in ass_list)
//{
//    Console.WriteLine(nice_ass);
//    //assembly_entry_pt.LoadModule(nice_ass);
//    var ass = Assembly.Load(nice_ass);
//    Console.WriteLine($"Current Assembly: {ass}");

//    var types_list = ass.DefinedTypes;

//    int meths_count = 0; 
//    foreach (var a_type in types_list)      // types-methods count
//    {
//        var meths_list = a_type.GetMethods(); //a_[m_a, m_b,...,]

//        meths_count += meths_list.Length;
//        //Console.WriteLine($"{a_type} has {meths_count} methods.");
//    }
//    Console.WriteLine($"Current Assembly: {ass} has {meths_count} methods.");
//}
//0 types with 0 methods in System.Runtime assembly.
//119 types with 1,491 methods in System.Linq assembly.
//44 types with 656 methods in System.Console assembly.

// Get the assembly that is the entry point for this app.
using System.Reflection;

Assembly? myApp = Assembly.GetEntryAssembly();
// If the previous line returned nothing then end the app.
if (myApp is null) return;
// Loop through the assemblies that my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);
    // Declare a variable to count the number of methods.
    int methodCount = 0;
    // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of all the methods.
        methodCount += t.GetMethods().Length;
    }
    // Output the count of types and their methods.
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
      arg0: a.DefinedTypes.Count(),
      arg1: methodCount,
      arg2: name.Name);
}