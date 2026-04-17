
int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int nbr_of_threads = 3;
int base_batch_size = arr.Length / nbr_of_threads;
int remainder = arr.Length % nbr_of_threads;

Thread[] threads = new Thread[nbr_of_threads];
int curr_sum = 0;
for (int i = 0; i < nbr_of_threads; i++)
{
    int start_i = i * base_batch_size + Math.Min(i, remainder);
    int batch_size_i = base_batch_size + (i < remainder ? 1 : 0);
    int end_i = start_i + batch_size_i;
    threads[i] = new Thread(() => SegmentSum(start_i, end_i));
    threads[i].Start();
    //curr_sum += SegmentSum(start_i, end_i);
}
curr_sum = threads[0 + threads[1];
Console.WriteLine(curr_sum);
int SegmentSum(int beg_i, int end_i)
{
    int curr_sum = 0;
    for (int i = beg_i; i < end_i; i++)
    {
        curr_sum += arr[i];
    }
    return curr_sum;
}

