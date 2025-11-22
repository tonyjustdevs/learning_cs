
// 1. add non-null int
//int some_int_nonnullable = null; // must comment out
//ok -"Cannot convert null to 'int' because it is a non-nullable value type"

// 2. print - error
//Console.WriteLine(some_int_nonnullable); // ok error: "Cannot convert null to 'int' because it is a non-nullable value type"

// 3. comment out 2.
// 4. add nullable int = null;
int? nullable_int = null;

// 5. print - ok
Console.WriteLine($"nullable_int: {nullable_int}");                       // ""
Console.WriteLine($"nullable_int.HasValue: {nullable_int.HasValue}");                       // ""
Console.WriteLine($"nullable_int.GetValueOrDefault(): {nullable_int.GetValueOrDefault()}");   // 0 

// 6. assign nullable int = 7;
nullable_int = 7;
Console.WriteLine($"nullable_int = 7: {nullable_int}");                       // ""
Console.WriteLine($"nullable_int.HasValue: {nullable_int.HasValue}");                       // ""
Console.WriteLine(nullable_int.GetValueOrDefault());   // 7

// 7. alternative syntax of null int
Nullable<int> AnotherNullableInt = 69;
Console.WriteLine($"pre-null: {AnotherNullableInt}");
Console.WriteLine($"pre-null.HasValue: {AnotherNullableInt.HasValue}");
AnotherNullableInt = null;
Console.WriteLine($"post-null: {AnotherNullableInt }");
Console.WriteLine($"pre-null.HasValue: {AnotherNullableInt.HasValue}");