Type prog_type = typeof(Program); // get Type of object describing Program type

Console.WriteLine($"p.Name: {prog_type.Name}");
Console.WriteLine($"p.IsPublic: {prog_type.IsPublic}");
Console.WriteLine($"p.BaseType: {prog_type.BaseType}");
Console.WriteLine($"p.GetInterfaces(): {prog_type.GetInterfaces()}");
Console.WriteLine($"p.Assembly: {prog_type.Assembly}");
Console.WriteLine($"p.GetProperties(): {prog_type.GetProperties()}");
Console.WriteLine($"p.GetMethods(): {prog_type.GetMethods()}");
Console.WriteLine($"p.GetFields(): {prog_type.GetFields()}");
//Console.WriteLine($"prog_type: {prog_type.GetCustomAttributes()}");




////throw new Exception();
//WriteLine("* Top-level functions example");
//WhatsMyNamespace(); // Call the function.
//void WhatsMyNamespace() // Define a local function.
//{
//    WriteLine("Namespace of Program class: {0}", arg0: typeof(Program).Namespace ?? "null");
//}
