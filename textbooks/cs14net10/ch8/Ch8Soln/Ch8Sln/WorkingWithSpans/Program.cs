// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello to WorkingWithSpan!");
// -------------------- [A] TEXT EXTRACTION: via SubString --------------------
// [1] add string 'name': "first_name last_name"
string name = "Samantha Jones";
            // 01234567890123 - indexes
            // 12345678901234 - lenght
// [2] get length: first_name
int first_name_len  = name.IndexOf(' ');

// [3] get length: last_name
int last_name_len   = name.Length - (first_name_len + 1); 
// [4] get idx: first_name
// [5] get idx: last_name
// [6] extract first_name via Substring

string first_name = name.Substring(0, first_name_len);
string last_name = name.Substring(name.Length - last_name_len, last_name_len);

// [7] extract last_name via Substring
Console.WriteLine("{0}-{1} via SubString()",first_name, last_name);

// -------------------- [B] TEXT EXTRACTION: via Span<T>, Range & Index --------------------
// [1] add Span<char> of name variable
ReadOnlySpan<char> name_ro_span = name.AsSpan();

// [2] get first_name from span_t[..TBAIndex]
var first_name_ro_span = name_ro_span[..first_name_len]; // from 0 to length of first_name
Console.WriteLine($"first_name_ro_span: {first_name_ro_span}");

// [3] get last_name from span_t[^TBAIndex..n]
var last_name_ro_span = name_ro_span[^last_name_len..]; // 5th from last to end
Console.WriteLine($"last_name_ro_span: {last_name_ro_span}");

//string name = "Samantha Jones";
//               01234567890123 - indexes
//               12345678901234 - lenght

// -------------------- [B] TEXT EXTRACTION 2: via Span<T>, Range & Index --------------------
//string name = "Samantha Jones";

ReadOnlySpan<char> name_span   = name.AsSpan();
int fname_len   = name.IndexOf(' ');
var fname_span = name_span[..fname_len];

int lname_len   = name.Length - (fname_len+1);

var lname_span = name_span[^lname_len..];
Console.WriteLine(name_span[^lname_len..]);
Console.WriteLine(fname_span);
Console.WriteLine(lname_span);
Console.WriteLine($"{fname_span}-{lname_span}");
//Console.WriteLine("{0}-{1}",fname_span, lname_span);


//var asdf = "samantha jones";
//            01234567890123 - 0,13
//            12345678901234 - 1,14
//            43210987654321
//           [123456789][01234]
//           [samantha ][jones]