using TPNS.Lumon.TPSharedModernLib;

Console.WriteLine("Welcome to Lumon Industries");

SeveredEmployee marky = new("Marky",true);
SeveredEmployee heleny = new("Helly",false);

//mark.SitInThePark();
//mark.WorkOnProject();

TimeClock clocky= new();

clocky.ClockIn(marky);
clocky.ClockIn(heleny);


heleny.Department = "Macrodata Refinement";