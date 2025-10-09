//using System.Data.Common;
//using System.Globalization;

using static System.Convert;
double[,] doubles = {
  { 9.49, 9.5, 9.51 },
  { 10.49, 10.5, 10.51 },
  { 11.49, 11.5, 11.51 },
  { 12.49, 12.5, 12.51 } ,
  { -12.49, -12.5, -12.51 },
  { -11.49, -11.5, -11.51 },
  { -10.49, -10.5, -10.51 },
  { -9.49, -9.5, -9.51 }
};

//int x_length = doubles.GetLength(0);
//int y_length = doubles.GetLength(1);

int rows_req = 8;
int cols_req = 3;
// print all vals
Console.WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32");

for (int i = 0; i < rows_req; i++)
{
	for (int j = 0; j < cols_req; j++)
	{
		Console.Write($"| {doubles[i,j],6} | {ToInt32(doubles[i, j]),7} ");
	}
    Console.WriteLine();
}

Console.WriteLine($"total elemnts: {doubles.Length}");

Console.WriteLine($"| double | AwayFromZero");
foreach (var d in doubles)
{
	Console.WriteLine("| {0,6} | {1,12}", d,Math.Round(d, 0, MidpointRounding.AwayFromZero));
	
    
}

