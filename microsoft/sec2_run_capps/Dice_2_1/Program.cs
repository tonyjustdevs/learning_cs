//Random dice = new Random(); // stateful method
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);    // stateless method


Random dice1 = new Random(); // instantiate dice
int val = dice1.Next(1,7);
Console.WriteLine(val);

Random dice2 = new(); //target-typed constructor invocation
int val2 = dice2.Next(1,7);
Console.WriteLine(val2);
