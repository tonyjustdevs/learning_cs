using System.Data;
using System.Reflection;

//DateTime dateTime_instance = new();
//Console.WriteLine($"dt_insance.isvaluetype: {dateTime_instance.GetType().IsValueType}");
//Console.WriteLine($"dt_type.isvaluetype: {typeof(DateTime).IsValueType}");

//Console.WriteLine($"dt_insance.IsByRef: {dateTime_instance.GetType().IsByRef}");
//Console.WriteLine($"dt_type.IsByRef: {typeof(DateTime).IsByRef}");

Type prog_type = typeof(Program);
PropertyInfo[] prog_type_list = prog_type.GetProperties();
//Console.WriteLine("Properties of Program Class:");
//foreach (PropertyInfo item in prog_type_list)
//{
//    Console.WriteLine($" - {item.Name}");
//}

string? prog_type_ns  = prog_type.Namespace?? "null_brah";
Console.WriteLine($"prog_type_ns: {prog_type_ns}");
//string? prog_type_ns = prog_type.Namespace;

//string prog_type_ns = prog_type_ns ?? "<null>";
//ff
//PropertyInfo[] myPropertyInfo;
//myPropertyInfo = Type.GetType("System.Type").GetProperties(); // Get the properties of 'Type' class object.
//Console.WriteLine("Properties of System.Type are:");
//for (int i = 0; i < myPropertyInfo.Length; i++)
//{
//    Console.WriteLine(myPropertyInfo[i].ToString());
//}


//DateTime dt_obj = new();
//Type dt_dotnet_type = dt_obj.GetType();
//PropertyInfo[] dt_type_prop_list = dt_dotnet_type.GetProperties();

//foreach (PropertyInfo item in dt_type_prop_list)
//{
//    Console.WriteLine($"item.Name (type)(dec_type)(getval): {item.Name} ({item.PropertyType}) ({item.DeclaringType}) ({item.GetValue(dt_obj)})");
//}


//PropertyInfo[] type = objType.GetProperties();

//Type dayTime_type_instance = dateTime_instance.GetType();

//foreach(
//    System.Reflection.PropertyInfo property in dayTime_type_instance.GetProperties())
//{
//    Console.WriteLine(property.Name);
//}