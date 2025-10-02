
using System.Reflection;
System.Data.DataSet ds = new();
HttpClient client = new();
Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp is null) return; // If the previous line returned nothing then end the app
foreach (AssemblyName name in myApp.GetReferencedAssemblies()) // Loop through the assemblies that my app references.
{// Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name); // Declare a variable to count the number of methods.
    int methodCount = 0; // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;// Add up the counts of all the methods.
    }
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",    // Output the count of types and their methods.
      arg0: a.DefinedTypes.Count(),
      arg1: methodCount,
      arg2: name.Name);
}
//0 types with 0 methods in System.Runtime assembly.
//44 types with 654 methods in System.Console assembly.
//110 types with 1,348 methods in System.Linq assembly.