Console.WriteLine("Hello to Thread App 5");
int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int nbr_of_threads = 4;
int remainder = arr.Length % nbr_of_threads;
int base_batch_sz = arr.Length/nbr_of_threads;


Thread[] threads = new Thread[nbr_of_threads];  // create threads list
int[] totals = new int[nbr_of_threads];         // create totals list

for (int i = 0; i < threads.Length; i++)
{
    // |123|546|78|90|
    // each thread has: [start_i, end_i] calculated from i
    int start_i = i * base_batch_sz + Math.Min(i, remainder);
    int batch_size_i = base_batch_sz + (i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;

    int local_i = i;


    Thread thread_i = new Thread(() =>
    {
        int curr_sum = 0;
        Console.WriteLine($"Thread_{local_i}: [{start_i}:{end_i}] (Thread:{Environment.CurrentManagedThreadId})");
        for (int j = start_i; j < end_i; j++)
        {
            Console.WriteLine($"-  {j} (Thread:{Environment.CurrentManagedThreadId})");
            curr_sum += arr[j]; // when loop finishes: [curr_sum] for thread is ready
        }
        totals[local_i] = curr_sum;
    });
    threads[local_i] = thread_i;
    threads[local_i].Start();
}

foreach (var item in threads)
{
    item.Join();
}
Console.WriteLine($"\nTotal Sum: {totals.Sum()} (Thread:{Environment.CurrentManagedThreadId})");

