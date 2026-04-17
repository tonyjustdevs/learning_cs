
//using System.Runtime.Intrinsics.X86;

//int result = 0;
int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12];
// 1-thread: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]:  approx 10-steps
// 2-thread: [1, 2, 3, 4, 5] [6, 7, 8, 9, 10]: approx 5-steps
// 3-thread: [1, 2, 3, 4] [4, 5, 6, 7] [8, 9, 10]: approx 5-steps too
//     
int nums_len = nums.Length;
int no_of_threads = 4;
int base_chunk_size = nums_len/ no_of_threads;      // 3=10//3
double chunk_size_remainder = nums_len - base_chunk_size * no_of_threads;
Console.WriteLine($"nums_len {nums_len} = (base_chunk_size * threads [{base_chunk_size}*{no_of_threads}]) + remainder {chunk_size_remainder}");
// try 3 threads
//[1,2][3,4][5,6][7,8]
//[0,1,2,3*][4,5,6][7,8,9]

//3, 3, 3, 3

// determine beg_idx, end_idx for each chunk
// 0, chunk_size+(remainder)
int curr_chunk_size=0;
int prev_j = 0;
int curr_j = 0;
int curr_i = 0;
int chunk_no = 0;
//int thread_no = 0;
for (int i = 1; i <= no_of_threads; i++)
{
    Console.WriteLine(i);
    chunk_no = i;
    curr_i = prev_j;
    curr_chunk_size = base_chunk_size;


    if (chunk_no <= chunk_size_remainder) //1/2/3/4 vs 2
    {
        Console.WriteLine($"chunk_{chunk_no}: increasing chunk size from: '{curr_chunk_size}' to '{curr_chunk_size+1}'");
        curr_chunk_size += 1;
    }
    curr_j = curr_i + curr_chunk_size;
    Console.WriteLine($"chunk_{chunk_no}_size_{curr_chunk_size}: req indexes [{curr_i},{curr_j}] ==> true indexes being [{curr_i},{curr_j-1}]");
    prev_j = curr_j;
}

    // int prev_j_0= 0
    /// |123|45 |67 |89 | (10)  : |1 of 4| i=[prev_j_0] , r=1 if [chunk_no_1]<=[rem] else r=0] => [curr_j_3]=current_i_0+[[base_2+r_1]] where 
    /// |i j|                     |1 of 4| [prev_j_3] = [curr_j_3]|
    /// |0 2| == actual required  |[0, 3] 
    
    /// |123|456|78 |9| (10)    : |2 of 4| i=[prev_j_3], r=1 if [chunk_no_2]<=[rem] else r=0] =>[curr_j_6]= current_i_3+[[base_2+r_1]] 
    ///     |i j|                 |2 of 4| [prev_j_6] = [curr_j_6]|
    ///     |3-5| == actual req   |[3, 6] 
    
    /// |123|456|78 |91|         : |2 of 4| i=[prev_j_6], where r=1 if [chunk_no_3]<=[rem] else r=0] [curr_j_6]=current_i_6+[[base_2+r_0]] 
    ///     |   |ij |                   |2 of 4| [prev_j_6] = [curr_j_6]|
    ///     |3-5| == actual req   |[3, 6] 

//    Console.WriteLine($"chunk_size: {curr_chunk_size} with [beg_idx,end_idx]: [{prev_j + curr_chunk_size},{i * curr_chunk_size + curr_chunk_size}]");
//    //chunk_size: 4 with[beg_idx, end_idx]: [0, 4]
//    Thread cool_thread = new Thread(() => DoWorkMethod(i, i * curr_chunk_size + curr_chunk_size));
//    //chunk_size: 4 with[beg_idx, end_idx]: [4, 8]
//    //chunk_size: 3 with[beg_idx, end_idx]: [6, 9]
//}


//void DoWorkMethod(int i, int j)
//{
//    Console.WriteLine($"I'm a new thread i,j=[{i},{j}] [tid:{Environment.CurrentManagedThreadId}");
//}




//Thread[] threads = new Thread[4];
//int i = 0;

//foreach (var thread in threads)
//{
//    Console.WriteLine($"[{i}]: [tid: {Environment.CurrentManagedThreadId}]");
//    i++;
//}







//DoSumSegment(nums_segment)
//int result = DoSum(nums);
//Console.WriteLine(result);

//var start_time = DateTime.Now;

//int DoSum(int[] nums)
//{
//    int csum = 0;
//    foreach (var num in nums)
//    {
//        Thread.Sleep(100);
//        csum += num;
//    }
//    return csum;
//}
//var end_time= DateTime.Now;
//var time_elapsed = end_time - start_time;
//Console.WriteLine("result: {0}, time: {1}",result, time_elapsed.TotalMilliseconds);