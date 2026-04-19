using System.Threading.Channels;

Console.WriteLine("Hello to ThreadApp4\n");

int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int nbr_of_threads = 4;
int base_batch_size = arr.Length / nbr_of_threads;
int remainder = arr.Length % nbr_of_threads;
Console.WriteLine($"arr.Length: {arr.Length}");
Console.WriteLine($"nbr_of_threads: {nbr_of_threads}");
Console.WriteLine($"base_batch_size: {base_batch_size}");
Console.WriteLine($"remainder: {remainder}");

Thread[] threads = new Thread[nbr_of_threads];
int[] total = new int[nbr_of_threads];
// create thread -> add to thread_list -> thread.start


// do simple shout thread
//void SomeWork()
//{
//    Console.WriteLine("doing work");
//}
//Thread thread1 = new Thread(SomeWork);
//Thread thread2 = new Thread(()=>Console.WriteLine("doing work"));
//string some_local_var = "hello";
//Thread thread3 = new Thread(()=>Console.WriteLine(some_local_var));

int zzz = 0;

Thread thread4 = new Thread(()=>
{
    int local_i = zzz; // i is shared, we need a new instance instead
    Console.WriteLine($"{local_i} [{Environment.CurrentManagedThreadId}]");
    int start_i = local_i * base_batch_size + Math.Min(remainder, local_i);
    int batch_size_i = base_batch_size + (local_i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;
    Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

    // [12] [34] [56][78][90]
    // [123][456][78][90]

    int total_i = 0;
    for (int j = start_i; j < end_i; j++)
    {
        total[total_i] += arr[j];
        Console.WriteLine($"- {total_i}: {total[total_i]}");
    }

});
//thread4.Start();

zzz = 1;
Thread thread5 = new Thread(() =>
{
    int local_i = zzz;
    Console.WriteLine($"{local_i} [{Environment.CurrentManagedThreadId}]");
    int start_i = local_i * base_batch_size + Math.Min(remainder, local_i);
    int batch_size_i = base_batch_size + (local_i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;
    Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

    // [12] [34] [56][78][90]
    // [123][456][78][90]

    int total_i = 0;
    for (int j = start_i; j < end_i; j++)
    {
        total[total_i] += arr[j];
        Console.WriteLine($"- {total_i}: {total[total_i]}");
    }

});
//thread5.Start();


zzz = 2;
Thread thread6 = new Thread(() =>
{
    int local_i = zzz;
    Console.WriteLine($"{local_i} [{Environment.CurrentManagedThreadId}]");
    int start_i = local_i * base_batch_size + Math.Min(remainder, local_i);
    int batch_size_i = base_batch_size + (local_i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;
    Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

    // [12] [34] [56][78][90]
    // [123][456][78][90]

    int total_i = 0;
    for (int j = start_i; j < end_i; j++)
    {
        total[total_i] += arr[j];
        Console.WriteLine($"- {total_i}: {total[total_i]}");
    }

});
//thread6.Start();


zzz = 3;
Thread thread7 = new Thread(() =>
{
    int local_i = zzz;
    Console.WriteLine($"{local_i} [{Environment.CurrentManagedThreadId}]");
    int start_i = local_i * base_batch_size + Math.Min(remainder, local_i);
    int batch_size_i = base_batch_size + (local_i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;
    Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

    // [12] [34] [56][78][90]
    // [123][456][78][90]

    int total_i = 0;
    for (int j = start_i; j < end_i; j++)
    {
        total[total_i] += arr[j];
        Console.WriteLine($"- {total_i}: {total[total_i]}");
    }

});
//thread7.Start();


//Console.WriteLine(total.Sum());

//for (int i = 0; i < threads.Length; i++)
//{
//    int start_i         = i * base_batch_size + Math.Min(remainder, i);
//    int batch_size_i    = base_batch_size + (i < remainder ? 1 : 0);
//    int end_i           = start_i + batch_size_i;
//    Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

//    // [12] [34] [56][78][90]
//    // [123][456][78][90]

//    int total_i = 0;
//    for (int j = start_i; j < end_i; j++)
//    {
//        total[total_i] += arr[j];
//        Console.WriteLine($"- {total_i}: {total[total_i]}");
//    }
//}
//Console.WriteLine(total.Sum());

// loop each thread: threads (0, 1, 2, 3)



//Thread thread = new Thread(CalcSum1);
//Thread thread = new Thread();
//thread.Start();
//void CalcSum1() {
//    int total=0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        total += arr[i];
//    }
//    Console.WriteLine(total);
//}


for (int i = 0; i < threads.Length; i++)
{
    int local_i = i;
    
    Thread thread_i = new Thread(() => {

        Console.WriteLine($"{local_i} [{Environment.CurrentManagedThreadId}]");
        int start_i = local_i * base_batch_size + Math.Min(remainder, local_i);
        int batch_size_i = base_batch_size + (local_i < remainder ? 1 : 0);
        int end_i = start_i + batch_size_i;
        Console.WriteLine($"start_i,end_i: [{start_i},{end_i}]");

        // [12] [34] [56][78][90]
        // [123][456][78][90]

        //int total_i = 0;
        //int total_i = i;
        for (int j = start_i; j < end_i; j++)
        {
            total[local_i] += arr[j];
            Console.WriteLine($"- {local_i}: {total[local_i]}");
        }
    });

    threads[i] = thread_i;
    threads[i].Start();
}
foreach (var thread in threads)
{
    thread.Join();
}
Console.WriteLine($"total.Sum(): {total.Sum()}");

