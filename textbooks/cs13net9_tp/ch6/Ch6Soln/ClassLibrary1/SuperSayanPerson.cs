
namespace TP.SharedLibraries;

public partial class Person
{
    public int SuperSayanLevel; // 1.   add [fld][per.cs] SuperSayanLevel
    public delegate void SuperSayanEventHandler(object? sender, EventArgs e);  // 2.   add [fld][per.cs] SuperSayanEventHandler
    public delegate void SuperSayanEventHandler<TEventArgs>(object? sender, TEventArgs e);  // 2.   add [fld][per.cs] SuperSayanEventHandler
    public SuperSayanEventHandler? SuperSayanify;
    public void Punch(Person person) // kim does punch() kim==this
    //public void Punch()
    {  // 3.   add [mth][per.cs] IncrPower()
        SuperSayanLevel += 1;  // 3a.  add [lgc][per.cs] SS_L++
        //Console.WriteLine($"[this]: {this.Name} got punched. SuperSayanLevel: {SuperSayanLevel}");
        Console.WriteLine($"{this.Name} punched {person.Name}. {this.Name}-SuperSayan: L{SuperSayanLevel}");
        if (SuperSayanLevel < 3) { return; }
        SuperSayanify?.Invoke(this, EventArgs.Empty); // (sender, e) // 3b.  add [lgc][per.cs] if SS_L>3 -> run SS_EH()
        SuperSayanLevel = 0;
        Console.WriteLine($"{this.Name} has taken a chill-pill. {this.Name}-SuperSayan: L{SuperSayanLevel}");
    }
    
     
     // 4.a  add [lgc][pro.cs] SS_SH_obj & Pers_obj
     // 4.b  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times
     // 4.c  add [lgc][pro.cs] SS_SH_obj +- Mth
     // 4.d  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times

}
