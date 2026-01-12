using System.Text;
using TPSharedNamespace;
using static System.Net.Mime.MediaTypeNames;

// [1] A fictional function that returns either a string value or null.
string  auth_name = getAuthName();
string? auth_name2 = getAuthName2();
string? auth_name3 = getAuthName2();

//Console.WriteLine($"auth_name: {auth_name}");
//Console.WriteLine($"auth_name2: {auth_name2}");

// [2] maxLength variable will be the length of authorName if it is
// not null, or 30 if authorName is null.
int maxLength = auth_name.Length;
int maxLength2 = auth_name2?.Length ?? 30;

// [3] The authorName variable will be "unknown" if authorName was null.
auth_name = auth_name ?? "unknown1a";
auth_name ??= "unknown1b";
auth_name2 = auth_name2 ?? "unknown2";
auth_name3 ??= "unknown3";
static string getAuthName() => "mate";
static string? getAuthName2() => null;
//Console.WriteLine($"auth_name: {auth_name}(exp: mate)");
//Console.WriteLine($"auth_name2: {auth_name2} (exp: unknown2)");
//Console.WriteLine($"auth_name3: {auth_name3} (exp: unknown3)");

//////// update customer ///

Customer cus_1 = new() { name="cus_name_1", age=1 };

//Console.WriteLine("name: {0}, age: {1}",cus_1.name, cus_1.age);
Customer.UpdateAge(cus_1, 11);
Customer.UpdateAge(null, 11);
Customer.UpdateAge2(null, 11);

//Console.WriteLine("name: {0}, age: {1}",cus_1.name, cus_1.age);



Console.WriteLine("\n\nProgram Initiated:\n");
Console.WriteLine("\n[1]Bits & Bytes\n");

byte[] BinaryObject = new byte[128];
string some_text = "G'day Mate!";

//Convert.to(some_text);
for (int i = 0; i < 10; i++)
{
    Console.Write($"{BinaryObject[i]:X2} ");
}
Console.WriteLine("\n");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{BinaryObject[i]:X}  ");
}

string BinaryObject_str = Convert.ToBase64String(BinaryObject);

Console.WriteLine("\n");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{BinaryObject_str[i]:X2} ");
}
Console.WriteLine("\n");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{BinaryObject_str[i]:X}  ");
}

Console.WriteLine("\n\nProgram Completed:\n");
