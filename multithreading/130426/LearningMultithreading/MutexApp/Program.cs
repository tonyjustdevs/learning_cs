Console.WriteLine("Hello Mutex App!");
// Scenarios:
// Use Two (Separate) Processes
// - With race conditions
// - Without race conditions

//////////////// start program //////////////// 
string file_path = Path.Join(Environment.CurrentDirectory, "counter.txt");
Console.WriteLine($"file_path: {file_path}");
int counter=0;

using var mutex = new Mutex(false, "global_counter_mutex");

for (int i = 0; i < 1_000; i++)
{
    try
    {
        mutex.WaitOne();
        counter = GetCounterFromFile(file_path);
        counter++;
        WriteCounterToFile(file_path, counter);

    }
    finally 
    {
        mutex.ReleaseMutex();
    }
    //break;
}

int GetCounterFromFile(string file_path) 
{
    using (var file_stream = File.Open(file_path, 
        mode: FileMode.OpenOrCreate, 
        access: FileAccess.ReadWrite,
        share: FileShare.ReadWrite)) 
    {
        using var stream_reader = new StreamReader(file_stream);
        int.TryParse(stream_reader.ReadToEnd(), out int counter); // "" -> fails -> 0 to counter
        //Console.WriteLine($"read: {counter}");
        return counter;
    }
};

void WriteCounterToFile(string file_path, int counter)
{
    using (var file_stream = File.Open(file_path,
        mode: FileMode.OpenOrCreate, 
        access: FileAccess.ReadWrite,
        share: FileShare.ReadWrite))
    {
        using var stream_writer = new StreamWriter(file_stream);
        //Console.WriteLine($"write: {counter}");
        stream_writer.WriteLine(counter);
    }
}

Console.WriteLine("Program Complete");
//////////////// end program //////////////// 

