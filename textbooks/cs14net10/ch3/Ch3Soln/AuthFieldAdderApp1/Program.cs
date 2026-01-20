using System.Text;
using TPSharedNamespace;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

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
Console.WriteLine("[1]Bits & Bytes\n");


Console.WriteLine("1. HTTP APIs");
byte[] bytes_object = System.IO.File.ReadAllBytes("fake.pdf");
string bytes_string = Convert.ToBase64String(bytes_object);

Console.WriteLine("2. Encoding/Decoding (Not Encryption)");

byte[] hello_txt2bin = Encoding.UTF8.GetBytes("hello");
string base64_str = Convert.ToBase64String(data);

byte[] hello_64str2bin = Convert.FromBase64String(base64_str);
string text = Encoding.UTF8.GetString(data);
