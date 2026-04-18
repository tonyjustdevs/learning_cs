
// sgl-thread-base-line 

using System.Threading;

int total = 0;

int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//for (int i = 0; i < arr.Length; i++)
//{
//    total += arr[i];
//}
//Console.WriteLine(total);


//Thread thread1 = new Thread(() =>
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        total += arr[i];
//    }
//    Console.WriteLine(total);
//});
//thread1.Start();

//int sum1 = 0;
//int sum2 = 0;

//Thread thread3 = new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        sum1 += arr[i];
//    }
//    Console.WriteLine(sum1);
//});

//Thread thread4 = new Thread(() =>
//{
//    for (int i = 5; i < arr.Length; i++)
//    {
//        sum2 += arr[i];
//    }
//    Console.WriteLine(sum2);
//});
//thread3.Start();
//thread4.Start();
//thread3.Join();
//thread4.Join();
//Console.WriteLine($"total: {sum1+sum2} ");


//int sum1 = 0;
//int sum2 = 0;
int nbr_of_threads=3;
int[] sums = new int[nbr_of_threads];
Thread[] threads = new Thread[nbr_of_threads];
int base_size_i = arr.Length / nbr_of_threads;
int remainder = arr.Length % nbr_of_threads;


for (int i = 0; i < nbr_of_threads; i++)
{
    //int i = i;
    int start_i = i * base_size_i + Math.Min(i, remainder);
    int batch_size_i = base_size_i + (i < remainder ? 1 : 0);
    threads[i] = new Thread(() =>
        {
            for (int j = start_i; j < start_i+ batch_size_i; j++)
            {
                Console.WriteLine($"i: {i}");
                sums[i] += arr[j]; //sums[i]: i in lambda exp is reference variable
                Console.WriteLine($"{j}: sums[{i}] = {sums[i]} (added: +{arr[j]})[{Environment.CurrentManagedThreadId}]");
            }
        });
    threads[i].Start(); 
}
foreach (var thread in threads)
{
    thread.Join();
}

Console.WriteLine(sums.Sum());

//Thread thread3 = new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        sum1 += arr[i];
//    }
//    Console.WriteLine(sum1);
//});
