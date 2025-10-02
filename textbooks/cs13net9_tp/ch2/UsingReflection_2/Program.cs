using System.Reflection; // Assembly, Typename
Assembly? app = Assembly.GetEntryAssembly();
if (app is null) return;
//AssemblyName[] ref_ass_lst = app.GetReferencedAssemblies();
foreach (AssemblyName ass_name in app.GetReferencedAssemblies())
{
    Assembly loaded_ass = Assembly.Load(ass_name);
    //Type[] some_lst = loaded_ass.GetExportedTypes();
    //Type[] some_lst = loaded_ass.GetForwardedTypes/**/();

    IEnumerable<TypeInfo> ass_types_lst = loaded_ass.DefinedTypes;

    int meth_count = 0;
    int type_count = 0;
    foreach (TypeInfo item in ass_types_lst)
    {
        //Console.WriteLine("AssTypes: [{0}]",item.Name);
        type_count += 1;
        var types_meth_lst = item.GetMethods();
        meth_count += types_meth_lst.Length;
        Console.WriteLine("[{0}] curr_ct: [{1}] [type_{2}]: {3}[{4}]", ass_name.Name, meth_count, type_count, item.Name, types_meth_lst.Length);
    }

    //Console.WriteLine(ass_name.Name);
}


//Type[] some_lst = loaded_ass.GetForwardedTypes();
//foreach (Type item in some_lst)
//{
//    Console.WriteLine(item.FullName);
//}
//Console.WriteLine("some_lst.Length: {0}" ,some_lst.Length);


//Console.WriteLine("assembly or app: [{0}]", ass);
//loaded_ass.FullName: System.Runtime, Version = 9.0.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a
//Console.WriteLine("loaded_ass.FullName: {0}", loaded_ass.FullName);
//loaded_ass.FullName: System.Console, Version = 9.0.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a

//var loaded_mods = loaded_ass.GetLoadedModules();
//foreach (var item in loaded_mods)
//{
//    Console.WriteLine("item.FullyQualifiedName: {0}", item.FullyQualifiedName);
//}
//ass_name
//Console.WriteLine("FullName {0}",ass_name.FullName);
//Console.WriteLine("Type_Name {0}", ass_name.GetType().Name);
//Console.WriteLine("ass_name_str {0}", ass_name.ToString());
//Console.WriteLine("ContType {0}", ass_name.ContentType.ToString());
//Console.WriteLine("ContType {0}", ass_name.);

//Func<AssemblyName[]> refass = ass.GetReferencedAssemblies;
//Console.WriteLine("refass_type: {0}", refass.GetType().FullName);

//var invoc_lst = refass.GetInvocationList;
//Console.WriteLine("refass_type: {0}", invoc_lst.GetType().FullName);

//var refass_str = refass.ToString();
//Console.WriteLine("refass_str: {0}", refass_str);



//Console.WriteLine("ass.GetTypes() - all types defined in ass: ");
//Type[] types_ass_list = ass.GetTypes(); // get all types defined in assembly
//IEnumerable<TypeInfo> types_ass_list = ass.DefinedTypes; // get all types defined in assembly
//types_ass_list.
//var types_ass_list = ass.CustomAttributes; // get all types defined in assembly
//Console.WriteLine($"{"Name",-15} {"BaseType",-15} {"Namespace",-15}");
//foreach (var item in types_ass_list)
//{   
//    //Console.WriteLine($"{item.Name,-15} {item.BaseType,-15} {item.Namespace,-15}");
//    //Console.WriteLine($"{item.NamedArguments,-15}");
//    var cust_attr_named_args_list = item.NamedArguments;
//    Console.WriteLine($"nm_arg {0}", cust_attr_named_args_list);
//}

//Console.WriteLine();

//IEnumerable<Module> app_modules = ass.Modules;
//Console.WriteLine("Modules in assembly.Modules:");
//foreach (Module app_module in app_modules)
//{
//    Console.WriteLine(app_module.Name);         // UsingReflection_2.dll
//    Console.WriteLine(app_module.ToString());   // UsingReflection_2.dll
//    Console.WriteLine(app_module.ScopeName);    // UsingReflection_2.dll
//}