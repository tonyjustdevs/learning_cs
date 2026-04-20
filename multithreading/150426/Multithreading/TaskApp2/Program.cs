using System.Runtime.ExceptionServices;

Console.WriteLine("Hello to TaskApp2!");

int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int nbr_of_threads = 4;
int batch_base_size = arr.Length / nbr_of_threads;
int remainder = arr.Length % nbr_of_threads;

// add threads list
// add sums list 
Thread[] threads = new Thread[nbr_of_threads];
Task[] tasks = new Task[nbr_of_threads];

int[] sums = new int[nbr_of_threads];

for (int i = 0; i < threads.Length; i++)
{   // [123][456][78][90]    
    int local_i = i;
    int start_i = local_i * batch_base_size + Math.Min(remainder, local_i);
    int batch_size_i = batch_base_size + (local_i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;

    // start_i and end_i for each thread is ready to filter the data array
    Console.WriteLine($"[tid:{Environment.CurrentManagedThreadId}]: [{start_i}:{end_i}]");

    // add thread per thread[local_i]
    //Thread thread = new Thread(() =>
    Task task = new Task(() =>
    {
        int currSum = 0;
        for (int j = start_i; j < end_i; j++)
        {
            currSum += arr[j];
            Console.WriteLine($"[tid:{Environment.CurrentManagedThreadId}]: - {j}");
        }
        sums[local_i] = currSum;
    });

    //threads[local_i] = thread;
    //threads[local_i].Start();
    tasks[local_i] = task;
    tasks[local_i].Start();  
}

//foreach (var thread in threads)
//{
//    thread.Join();
//}
foreach (var task in tasks)
{
    task.Wait();
}


Console.WriteLine(sums.Sum());

// how do  Tasks work?

