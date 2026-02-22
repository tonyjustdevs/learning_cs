
//using Microsoft.Win32.SafeHandles;

using System.Text;
using System.Text.Unicode;

Console.WriteLine("Welcome to WorkingWithRandomAccess App!");


// add "file"
// create handle to "file"
var coffee_handle = File.OpenHandle("coffee.txt", FileMode.Create, FileAccess.Write);

// create [New] txt file
// - via [handle]
// - send [buffer]
// - from [offset 0]
byte[] coffee_bytes = UTF8Encoding.UTF8.GetBytes("cafe");
WriteLine($"\ncoffee_bytes: {coffee_bytes}");

foreach (var coffee_byte in coffee_bytes)
{
    WriteLine($"- {coffee_byte}");
}

string coffee_str = UTF8Encoding.UTF8.GetString(coffee_bytes);
WriteLine($"\n{coffee_str} (via UTF8.GetString(coffee_bytes)");

await RandomAccess.WriteAsync(
    handle: coffee_handle,
    buffer: coffee_bytes,
    fileOffset: 0);