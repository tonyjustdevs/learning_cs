
using System.Xml.Linq;

int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

int nbr_of_threads = 3; 
int base_batch_size = arr.Length / nbr_of_threads;  // 3
int remainder = arr.Length % nbr_of_threads;      // 2

for (int i = 0; i < nbr_of_threads; i++)
{
    int start_i         = i * base_batch_size + Math.Min(remainder, i);
    int batch_size_i    = base_batch_size + (i < remainder ? 1 : 0);

}

