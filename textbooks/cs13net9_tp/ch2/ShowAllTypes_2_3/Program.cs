// Get the assembly that is the entry point for this app.

using System.Reflection;
Assembly? myApp = Assembly.GetEntryAssembly();

DateTime when = new(2000, 06, 12);

if (myApp is null) return;                      // If the previous line returned nothing then end the app.

foreach (AssemblyName name in myApp.GetReferencedAssemblies()) // Loop through the assemblies that my app references.
{
    Assembly a = Assembly.Load(name); // Load the assembly
    int methodCount = 0;                        // Declare variable to count number of methods.
    foreach (TypeInfo t in a.DefinedTypes)      // Loop through all types in assembly.
    {
        methodCount += t.GetMethods().Length;   // Add counts of all methods.
    } 
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", 
      arg0: a.DefinedTypes.Count(),             // Output the count of types and their methods.
      arg1: methodCount,
      arg2: name.Name);
}


