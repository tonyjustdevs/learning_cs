using TP.SharedLibraries;


Player2 p = new Player2();  
p.AchievementIntUnlocked += some_fn;
//p.AchievementUnlocked += some_fn2;
await p.AddPoints(30);
await p.AddPoints(30);
await p.AddPoints(30);
await p.AddPoints(30);

static void some_fn(int points)
{
    Console.WriteLine($"You Win! [some_fn]");
}
;



//static void some_fn2(string points){
//    Console.WriteLine($"You Win! [some_fn2]"); 
//};

//static void some_fn(int points)
//{
//    Console.WriteLine($"You Win from Program.cs. Total: {points}");
//};