// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Randoming Project!");

Random r = new Random();

// create some list
var RandomListOfPlayers = r.GetItems(
    new[] { "Messi", "Iniesta", "Xavi", "Neymar" },10);


foreach (var player in RandomListOfPlayers)
{
    Console.WriteLine("Player: {0}",player);
};

RandomListOfPlayers.Shuffle();

Console.WriteLine("\nPlayers Shuffled...\n");

foreach (var player in RandomListOfPlayers)
{
    Console.WriteLine("Player: {0}", player);
}
;

