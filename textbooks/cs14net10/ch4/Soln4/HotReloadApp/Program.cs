using static System.Console;

while (true)
{
    WriteLine("Gday, Hot Reload!");
    await Task.Delay(3000);
    WriteLine("not nice!");
    await Task.Delay(1000);
}