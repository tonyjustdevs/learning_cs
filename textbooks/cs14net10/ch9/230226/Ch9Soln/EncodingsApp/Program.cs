using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;

Console.Clear();
WriteLine("Hello Encodings App\n");

#region 0_PsuedoCode
// [PART A: Encode] string -> encode() -> encoded_bytes 
// [1]  read [console_key ]
// [2]  choose [encoding] based on console_ley
// [3]  show [encoding] (type) chosen
// [4]  get [encoded_bytes] of string "Café £4.39", show msg and msg.len
// [PART B: Decode with different encodings]
// [5a BadEncoding] encoded_bytes -> decoding_1 -> decoded_string_1
// [5b BadEncoding] encoded_bytes -> decoding_2 -> decoded_string_2
#endregion


#region [PART A: Encode] string -> encode() -> encoded_bytes 
// [1]  read [console_key]
Write("Press a key-stroke: ");
ConsoleKeyInfo key_pressed = ReadKey(false);

WriteLine($"\n\nYou pressed: '{key_pressed.Key}' ");
ReadKey(intercept: false);

Encoding selected_encoding; 

switch (key_pressed.Key)
{
    case ConsoleKey.D1:
        selected_encoding = Encoding.UTF8;
        break;
    case ConsoleKey.D2:
        selected_encoding = Encoding.UTF32;
        break;
    case ConsoleKey.D3:
        selected_encoding = Encoding.Unicode;
        break;
    case ConsoleKey.D4:
        selected_encoding = Encoding.BigEndianUnicode;
        break;
    case ConsoleKey.D5:
        selected_encoding = Encoding.Latin1;
        break;
    case ConsoleKey.D6:
        selected_encoding = Encoding.ASCII;
        break;
    default:
        selected_encoding = Encoding.Default;
        break;
};

WriteLine($"- {selected_encoding.EncodingName} selected.");
ReadKey(intercept: false);

//string string_to_encode = "tony";
string string_to_encode = "Café £4.39";

WriteLine($"- Encoding String:\t'{string_to_encode}' (length: {string_to_encode.Length})");
ReadKey(intercept: false);

byte[] encoded_bytes_array = selected_encoding.GetBytes(string_to_encode);

Write($"- Encoded Bytes: \t[");
foreach (var byte_item in encoded_bytes_array)
{
    Write($" {byte_item}");
}
Write($" ] (length: {encoded_bytes_array.Length})");
ReadKey(intercept: false);
#endregion
#region [PART B: Decode with different encodings]
// [5a BadEncoding] encoded_bytes -> decoding_1 -> decoded_string_1

DecodeBytesWithChosenEncoding(Encoding.ASCII, encoded_bytes_array);

DecodeBytesWithChosenEncoding(Encoding.UTF8, encoded_bytes_array);

DecodeBytesWithChosenEncoding(selected_encoding, encoded_bytes_array);
static void DecodeBytesWithChosenEncoding(Encoding chosen_encoding, byte[] encoded_bytes_array) { 
    Encoding chosen_decoding = chosen_encoding;

    WriteLine($"\n\nDecoding with: '{chosen_decoding.EncodingName}' ");
    ReadKey(intercept: false);

    Write($"- Decoding Bytes:\t[");
    foreach (var byte_item in encoded_bytes_array)
    {
        Write($" {byte_item}");
    }
    Write($" ] (length: {encoded_bytes_array.Length})");
    ReadKey(intercept: false);

    Write($"\n- Decoded String:\t");
    WriteLine($"'{chosen_encoding.GetString(encoded_bytes_array)}'");
    ReadKey(intercept: false);
}

#endregion 
WriteLine("\n\nProgram Completed.\n");

//C#selectedEncoding = keyPressed.Key switch {
//ConsoleKey.D1 => Encoding.UTF8,
//    // ...
//    _ => Encoding.UTF8  // Safer default
//};