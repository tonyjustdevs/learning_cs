
Console.WriteLine("Hello ReadTxtViaHandleApp");

//var coffee_handle = File.OpenHandle("coffee.txt", FileMode.Open, FileAccess.Read, FileShare.None);
var coffee_handle = File.OpenHandle("cafe.txt", FileMode.Open, FileAccess.Read, FileShare.None);
long coffee_handle_length =  RandomAccess.GetLength(coffee_handle);

WriteLine($"coffee_handle: {coffee_handle} [length: {coffee_handle_length}]");



//await RandomAccess.ReadAsync(coffee_handle, coffee_wbuffer, fileOffset: 0);
// create file handle
// - mode: open only
// - access: read
// - buffer: writeable

// create writeable buffer
// - get handle_length
// - create buffer using handle_length