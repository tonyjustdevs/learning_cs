int b = Random.Shared.Next(1, 5);
//var b = a;
switch (b)
{
	case 1:
		Console.WriteLine($"got 1...{b}");
		goto case 2;
	case 2:
        Console.WriteLine($"landed at 2: {b}");
		break;
	case 3:
        Console.WriteLine($"3s a crowd: {b}");
		break;
    case 5:
        Console.WriteLine($"5 d: {b}");
        break;
	default:
        Console.WriteLine($"defaults to 4: {b}");
		break;
}