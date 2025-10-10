
//Console.Write("How many eggs in a dozen? ");

//string? input_string = Console.ReadLine();


//if (int.TryParse(input_string, out int count_int))
//{
//    Console.WriteLine($"There are {count_int} in a dozen");
//}
//else
//{
//    Console.WriteLine($"{input_string} cannot be parsed into int");
//}


bool success = Uri.TryCreate("https://localhost:5000/api/customers",
  UriKind.Absolute, out Uri serviceUrl);


Console.WriteLine(success);