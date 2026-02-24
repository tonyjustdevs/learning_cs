
using System.Text;

while (true)
{
    Console.Clear();
    WriteLine("\nWelcome to Encoder App");
    WriteLine("\nPress a number to choose an encoding: ");
    ConsoleKeyInfo pressed_key = ReadKey(intercept:false);

    Encoding encoder;

    switch (pressed_key.Key)
    {
	    case ConsoleKey.D1:
		    encoder = Encoding.UTF8;
		    break;
        case ConsoleKey.D2:
            encoder = Encoding.Unicode;
            break;
        case ConsoleKey.D3:
            encoder = Encoding.ASCII;
            break;
        case ConsoleKey.D4:
            encoder = Encoding.Unicode;
            break;
        case ConsoleKey.D5:
            encoder = Encoding.Latin1;
            break;
        case ConsoleKey.D6:
            encoder = Encoding.BigEndianUnicode;
            break;
        default:
            encoder = Encoding.UTF8;
		    break;
    }

    string message = "Café £4.39";

    var encoded_bytes = encoder.GetBytes(message);
    WriteLine($"\n\n'{encoder.EncodingName}' Chosen: '{message}' [len: {message.Length}] encoded to {encoded_bytes.Length} bytes\n ");
    // choose different decoders

    foreach (byte b in encoded_bytes)
    {
        WriteLine($"{b,4} | {b,3:X} | {(char)b,4}");
    }
    // Decode the byte array back into a string and display it.
    string decoded = encoder.GetString(encoded_bytes);
    WriteLine($"Decoded: {decoded}");
    ReadKey(false);
};

//decoder = Encoding.UTF8;
//decoder = Encoding.Unicode;
//decoder = Encoding.ASCII;
//decoder = Encoding.Latin1;
//decoder = Encoding.BigEndianUnicode;
//GetFrileInfo();

//"Café £4.39";