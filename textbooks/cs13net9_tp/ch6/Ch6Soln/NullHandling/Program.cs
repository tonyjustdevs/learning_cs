
// 1. add non-null int
//int some_int_nonnullable = null; // must comment out
//ok -"Cannot convert null to 'int' because it is a non-nullable value type"

// 2. print - error
//Console.WriteLine(some_int_nonnullable); // ok error: "Cannot convert null to 'int' because it is a non-nullable value type"

// 3. comment out 2.
// 4. add nullable int = null;
int? some_int_nullable = null;

// 5. print - ok
Console.WriteLine(some_int_nullable);                       // ""
Console.WriteLine(some_int_nullable.GetValueOrDefault());   // 0 

// 6. assign nullable int = 7;
some_int_nullable = 7;
Console.WriteLine(some_int_nullable);                       // 7
Console.WriteLine(some_int_nullable.GetValueOrDefault());   // 7

