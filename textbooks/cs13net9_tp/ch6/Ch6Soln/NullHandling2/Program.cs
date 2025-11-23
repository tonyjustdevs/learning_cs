Console.WriteLine("Hello to Null Handler 2!");

// 1. add non-nullable int
int non_null_int = 420;
Console.WriteLine($"non_null_int: {non_null_int}");
//non_null_int = null; // this will fail

// 2. add nullable int
int? null_int = 69;
null_int = null;
Console.WriteLine($"null_int: {null_int}");

// 3. add nullable_or_default int
int? null_def_int = 666;
Console.WriteLine($"null_def_int.GetValueOrDefault(): {null_def_int.GetValueOrDefault()} [exp: 666]");

null_def_int = null;
Console.WriteLine($"null_def_int.GetValueOrDefault(): {null_def_int.GetValueOrDefault()} [exp: 0]");

Console.WriteLine($"null_def_int.GetValueOrDefault(): {null_def_int.GetValueOrDefault(555)} [exp: 555]");
