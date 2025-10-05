int rando_int = Random.Shared.Next(0, 5);

switch (rando_int)
{
    case 1:
        WriteLine("winner 1, chicken dinner!");
        break;
    case 2:
        WriteLine("2s company!");
        goto case 1;
    case 3:
    case 4:
        WriteLine("runner-upperers 3 & 4...");
        break;
    default:
        WriteLine("loser 5 the jive :/");
        break;
}
