
using System.ComponentModel;

Console.WriteLine("Hello, Span App!");
Console.WriteLine("\n[A] CREATE 'INDEX' INSTANCES\n");

// create 4 Index instances
// [1] Index start via: new()
// [1] Index start via: value

Index idx1a = new(value: 69);
Index idx1b = 420;
Index idx1c = new Index(888);

// [2a] Index rev via: new(...,fromend:t)
// [2b] Index rev via: ^value

Index idx2a = new(666, fromEnd: true);
Index idx2b = ^555;
Index idx2c = new Index(777, fromEnd: true);

Console.WriteLine($"idx1a: {idx1a}, {idx1a.GetType()}");
Console.WriteLine($"idx1b: {idx1b}, {idx1b.GetType()}");
Console.WriteLine($"idx1c: {idx1c}, {idx1c.GetType()}");
Console.WriteLine($"idx2a: {idx2a}, {idx2a.GetType()}");
Console.WriteLine($"idx2b: {idx2b}, {idx2b.GetType()}");
Console.WriteLine($"idx2c: {idx2c}, {idx2c.GetType()}");


Console.WriteLine("\n[B] CREATE 'RANGE' INSTANCES\n");

Range rng1 = new(start: new Index(3), end: new Index(7));
Range rng2 = new(3,7);
Range rng3 = 3..7;

Range rng4 = Range.StartAt(3);
Range rng5 = 3..;

Range rng6 = Range.EndAt(7);
Range rng7 = ..7;

Console.WriteLine($"{rng1} (exp: 3..7)");  
Console.WriteLine($"{rng2} (exp: 3..7)");  
Console.WriteLine($"{rng3} (exp: 3..7)");  
Console.WriteLine($"{rng4} (exp: 3..^0)"); 
Console.WriteLine($"{rng5} (exp: 3..^0)"); 
Console.WriteLine($"{rng6} (exp: 0..7)");  
Console.WriteLine($"{rng7} (exp: 0..7)");  

Console.WriteLine("\n[C] NAME EXTRACTION: 2 SUBSTRING VS SPAN\n");
Console.WriteLine("\n[C1] SUBSTRING\n");

string name = "Samantha Jones"; // len:15 flen:8 llen:5
//"Samantha Jones";
//"01234567890123"; 
// ........890123 = len-fnamelen = 
// .........90123 = len-fnamelen-1 = 
int length_fname = name.IndexOf(' ');
int length_lname = name.Length - length_fname - 1;

Console.WriteLine($"name: {name}, length_firstname: {length_fname}, length_lname: {length_lname}");

// [C1] SUBSTRING
string fname = name.Substring(0, length_fname);
string lname = name.Substring(length_fname + 1, length_lname);
string lname2 = name.Substring(name.Length-length_lname, length_lname);
Console.WriteLine($"fname: {fname} (via Substring()");
Console.WriteLine($"lname: {lname} (via Substring()");
Console.WriteLine($"lname2: {lname2} (via Substring()");

// [C2] SPAN 
Console.WriteLine("\n[C2] SPAN\n");

ReadOnlySpan<char> nameSpan = name.AsSpan();
int spaceIndex = nameSpan.IndexOf(' ');
Console.WriteLine($"nameSpan.IndexOf(' '): \t\t{spaceIndex} \t\t[exp: 8]");

var fname_span = nameSpan[..spaceIndex];
Console.WriteLine($"nameSpan[..spaceIndex]: \t{fname_span} \t[exp: 'Samantha']");

var lname_span = nameSpan[(spaceIndex + 1)..];
Console.WriteLine($"nameSpan[(spaceIndex + 1)..]: \t{lname_span} \t\t[exp: 'Jones']");

// count backwards from the end - lastnamelen
//Console.WriteLine($"length_lname: {length_lname}");
var lname_span2 = nameSpan[^5..];
var lname_span3 = nameSpan[^length_lname..];
Console.WriteLine($"nameSpan[^5..]: \t\t{lname_span2} \t\t[exp: 'Jones']");
Console.WriteLine($"nameSpan[^length_lname..]: \t{lname_span3} \t\t[exp: 'Jones']");

//"Samantha Jones";
//"01234567890123"; 

// [C3] EFFICIENT STRING/TEXT CALCULATION VIA SPAN  (E.G. "3+23+34")
// [C3] EFFICIENT STRING/TEXT CALCULATION VIA SPAN  (E.G. "3+23+34")
Console.WriteLine("\n[C3] EFFICIENT TEXT CALCULATIONS VIA SPAN\n");

// [a]  add string variable 'og_string' with math operators '+'
string og_string = "23+1+45+351"; //2,24,69,420

// [b]  convert to text_span = ... ReadOnlySpan<char>
ReadOnlySpan<char> text_span = og_string.AsSpan();
Console.WriteLine($"text_span: {text_span}");

// [c]  declare sum=0;
int sum = 0;

// [e]  get Range range_by_plus from .split('+') by math operator '+'
var text_span_split_rng =text_span.Split('+');
//Console.WriteLine($"text_span_split.Current: {text_span_split.Current}");

foreach (Range span_rng in text_span_split_rng) 
{
    // Console.WriteLine($"span_part: {span_rng} [{span_rng.GetType()}]");   // span_part(is type [System.Range])
    var text_span_split = text_span[span_rng]; // needs to be intparsed
    int text_span_split_int = int.Parse(text_span_split);
    sum += text_span_split_int;
    Console.WriteLine($"int.Parse(text_span_split): {text_span_split_int} (current_sum = {sum}])"); // [exp: [1],[23],[45], [351]"); // ReadOnlySpan<char>

    // [f] convert span to int

    //int split_int_span = split_txt_span.TryParse(out int span_int);
}

Console.WriteLine($"FINAL SUM: {sum} (exp: 420)");




// [f]  foreach r:
//var text_span_rng = text_span.Split('+');
//Console.WriteLine($"text_span_rng.GetEnumerator(): {text_span_rng.GetEnumerator()}");

//typeof(text_span_rng);
//foreach(Range r)
// [f]      sum += intParse(text_span[range_by_plus])  <-------- curr rng eg: text_span[0,1]..[2,3,4]..[5,6]

// [g]  print sum


//Console.WriteLine($"text_span_spliteted: {text_span_spliteted}");

