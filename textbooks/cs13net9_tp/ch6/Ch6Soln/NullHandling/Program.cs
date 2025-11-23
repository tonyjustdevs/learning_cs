using NullHandling;
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

// 8. addy stuff //    [3] Call the default parameterless constructor

Address addy1 = new();
Console.WriteLine($"addy1: {addy1}");
Console.WriteLine($"addy1.Building: {addy1.Building}");
Console.WriteLine($"addy1.Street: {addy1.Street}");
Console.WriteLine($"addy1.Region: {addy1.Region}");
Console.WriteLine($"addy1.City: {addy1.City}");

//addy1: NullHandling.Address
//addy1.Building:   
//addy1.Street:
//addy1.Region:

Address addy2 = new("sydney");

Console.WriteLine($"addy2: {            addy2}");
Console.WriteLine($"addy2.Building: {   addy2.Building}");
Console.WriteLine($"addy2.Street: {     addy2.Street}");
Console.WriteLine($"addy2.Region: {     addy2.Region}");
Console.WriteLine($"addy2.City: {       addy2.City}");
