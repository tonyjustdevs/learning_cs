// See https://aka.ms/new-console-template for more information

using Microsoft.Win32.SafeHandles;
using System;
using System.Buffers;
using System.Text;

Console.WriteLine("Hello, World!");

SafeFileHandle handle = File.OpenHandle("coffee.txt", FileMode.Create, FileAccess.ReadWrite);

//string output_text = "Café" + NewLine;
string output_text = "Café";

byte[] byte_array = UTF8Encoding.UTF8.GetBytes(output_text);

ReadOnlyMemory<byte> buffer_write_from = new(byte_array);
await RandomAccess.WriteAsync(handle, buffer_write_from, fileOffset: 0);

long read_buffer_byte_size = RandomAccess.GetLength(handle);
Write($"read_buffer_byte_size: {read_buffer_byte_size} (exp: 6)");
// determine file size in bytes

// create a buffer to read from file
byte[] byte_array_to_write = new byte[read_buffer_byte_size];
Memory<byte> buffer_memory_to_write = new(byte_array_to_write);

int i = 0;

WriteLine("\n[1] Printing empty buffer [byte-values aka 0's]");
foreach (var byte_item in buffer_memory_to_write.ToArray())
{
    WriteLine($"{i}: {byte_item}");
    i++;
}


WriteLine("\n[2] Printing filled buffer [byte-values]:  ");
await RandomAccess.ReadAsync(handle, buffer_memory_to_write, fileOffset: 0);

i = 0; 
foreach (var byte_item in buffer_memory_to_write.ToArray())
{
    WriteLine($"{i}: {byte_item}");
    i++;
}


WriteLine("\n[3] Printing filled buffer [str-values]:  ");
await RandomAccess.ReadAsync(handle, buffer_memory_to_write, fileOffset: 0);

i = 0;
;
//
foreach (var str_item in UTF8Encoding.UTF8.GetString(buffer_memory_to_write.ToArray()))
{
    WriteLine($"{i}: {str_item}");
    i++;
}

