
Console.WriteLine("Welcome to HighPerfFileCopyApp!");

var handle_coffee = File.OpenHandle("coffee.txt", FileMode.Open, FileAccess.Read);
var handle_coffee_copy = File.OpenHandle("coffee_copy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
var coffee_size_bytes = RandomAccess.GetLength(handle_coffee);
Memory<byte> max_buffer_per_read = new byte[8192];         // better
long current_offset = 0;
while (current_offset < coffee_size_bytes){
    var bytes_read= RandomAccess.ReadAsync(,handle_coffee, max_buffer_per_read, fileOffset: current_offset);
    await RandomAccess.WriteAsync(handle_coffee_copy, max_buffer_per_read, fileOffset: current_offset);
    current_offset += bytes_read;
    await Task.Delay(2000);
}



////////////////////////////////////////////////////////////////////////////////////

// 1. get [size] of handle (aka file)           : [coffee_size_bytes]
// 2. create memory-buffer of [size] of handle         :
// 3a. [tiny file]  fill buffer all at once     :
// 3b. [big file]   fill buffer via loop chunks :

//Memory<byte> buffer1 = new(new byte[coffee_size_bytes]);    // newb 
// Build a console app that copies a file from one path to another using:
// - File.OpenHandle
// - RandomAccess.ReadAsync
// - RandomAccess.WriteAsync
// - A reusable Memory<byte> buffe

// Constraints
// - No FileStream
// - No File.ReadAllBytes
// - Must work for large files
// - Must allow buffer size to be configurable


//var handle = File.OpenHandle("copyfrom.txt", FileMode.Open, FileAccess.Read);
//var file_size_bytes = RandomAccess.GetLength(handle);
//WriteLine($"file: {file_size_bytes}");