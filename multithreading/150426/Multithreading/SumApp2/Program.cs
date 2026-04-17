
// scenario-1: equal division 
// 12 / 3 = lenght / threads(or splits/batches) = 4 size per batch
// 3_threads:
// |0123|
// |4567|
// |8901|
// start_0 = 0*4 = 0 + batch_size
// start_1 = 1*4 = 4
// start_2 = 2*4 = 8

//batch_size = base + [if i<remainder,1,0]

// scenario-2: unequal division with remainder
// 11 / 3 = length / threads(or splits/batches) = 3 size per batch

//Console.WriteLine(11/3); // 3 threads of size: 3
//Console.WriteLine(11%3); // remainder: 2

//start_i = i * base + Math.Min(i, remainder);
//0 : 0123: 0*3+ 0 = 0
//1 : 4567: 1*3+ 1 = 4    
//2 : 891
// :  2 remainder


int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; // 11
int threads = 3;
int base_size = arr.Length / threads;       // 3
int remainder = arr.Length % threads;       // 2
int start_i = 0;
int curr_batch_size = 0;
int currSum=0;
for (int i = 0; i < threads; i++)
{
    start_i = i*base_size + Math.Min(i, remainder);
    curr_batch_size = base_size + (i < remainder ? 1 : 0);
    Console.WriteLine("{0},{1}",start_i, start_i+curr_batch_size);
    currSum = currSum + doSum(start_i, start_i + curr_batch_size);
}

Console.WriteLine($"Sum is {currSum}");
int doSum(int beg_i, int end_i)
{
    int currSum = 0;
    Console.WriteLine($"Summing {beg_i} to {end_i}");
    for (int i = beg_i; i < end_i; i++)
    {
        currSum += arr[i];
    }
    return currSum;
}
