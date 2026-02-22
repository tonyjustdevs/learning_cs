
using Microsoft.Win32.SafeHandles;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Text;

Console.WriteLine("Hello ReadTxtViaHandleApp");
// add file_handle
SafeFileHandle file_hdl = File.OpenHandle("cafe.txt", FileMode.Open, FileAccess.Read, FileShare.None);
long file_hdl_size = RandomAccess.GetLength(file_hdl);

// create [memory_view]
Memory<byte> read_mem_bytes = new byte[file_hdl_size]; // [memory_view] -> [bytes_in_memory]
WriteLine($"memory_buffer_window: {read_mem_bytes}");

// read handle to memory
await RandomAccess.ReadAsync(file_hdl, read_mem_bytes, 0);

// print contents of 
var read_mem_str = UTF8Encoding.UTF8.GetString(read_mem_bytes.ToArray());
WriteLine($"read_mem_bytes: {read_mem_bytes} [exp: system.memory<byte>");
WriteLine($"read_mem_str: {read_mem_str} [exp: 'cafe1']");

