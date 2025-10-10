using static System.Convert;

byte[] byte_obj_arr = new byte[128];

Random.Shared.NextBytes(byte_obj_arr); // Populate the array with random bytes.
int k = 0;
for (int i = 0; i < 16; i++)
{
	for (int j = 0; j < 8; j++)
	{
		Console.Write($"{byte_obj_arr[k],3} ");
		k++;
	}
    Console.WriteLine();
}
Console.WriteLine();

int l = 0;
for (int i = 0; i < 16; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write($"{byte_obj_arr[l],3:X2} ");
        l++;
    }
    Console.WriteLine();
}

string encoded_byte_arr_str = ToBase64String(byte_obj_arr);
Console.WriteLine($"encdoed: {encoded_byte_arr_str}");




// 16*8
// print hex bytes

// Convert the array to Base64 string and output as text.



