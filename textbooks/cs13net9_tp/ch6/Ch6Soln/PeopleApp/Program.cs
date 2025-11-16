using PeopleApp;
using System.Reflection.Metadata;
using System.Threading.Channels;
using TP.SharedLibraries;
using static TP.SharedLibraries.Person;
// [1] create person instance 

Person anais = new Person()
{
    Name = "Anais",
    DOB = new DateTimeOffset(2000, 01, 01, 0, 0, 0, 0, TimeSpan.Zero)
};
Console.WriteLine("Welcome to '{0}'s Saigon Love Story", anais.Name);
anais.WriteToConsole();

Console.WriteLine("before bangin");
anais.WriteKidsToConsole(); // get kiddo info   (#no kids)
// [2] create kiddos instance
List<Person> harry_kiddos = new() {
    new Person(){Name="adolf"},
    new Person(){Name="ikea"},
    new Person(){Name="dryck!"}
};
anais.Children = harry_kiddos;

// [3] get person object info
Console.WriteLine("after bangin");
anais.WriteKidsToConsole(); // get kiddo info   (#no kids)

Console.WriteLine("'{0}' pre-marriage: {1}", anais.Name, anais.Spouses.Count);
Person.Marry(anais, new Person() { Name = "mr bean" });
Console.WriteLine("'{0}' pos-marriage: {1}", anais.Name, anais.Spouses.Count);
Console.WriteLine("'{0}''s spouse-name: {1}", anais.Name, anais.Spouses[0].Name);

Console.WriteLine("To be continued...");

Person kim = new Person() { Name = "kim", DOB = new(2000, 01, 01, 0, 0, 0, TimeSpan.Zero) };

Console.WriteLine();
kim.WriteToConsole();
Console.WriteLine($"kim.isMarried: {kim.isMarried}, kim.Spouses.Count(): {kim.Spouses.Count()}");
Console.WriteLine("kim.Marry(new Person(){...} was run!");
kim.Marry(new Person() { Name = "danny boy", DOB = new(1990, 01, 01, 0, 0, 0, 0, TimeSpan.Zero) });
Console.WriteLine($"kim.isMarried: {kim.isMarried}, kim.Spouses.Count(): {kim.Spouses.Count()}");


//Console.WriteLine();
//Person anais    = new Person() { Name = "anais", DOB = new(2001, 01, 01, 0, 0, 0, TimeSpan.Zero) };
//Person jordana  = new Person() { Name = "jordana", DOB = new(2000, 01, 01, 0, 0, 0, TimeSpan.Zero) };

//anais.WriteToConsole();
//jordana.WriteToConsole();

//// use [MarriageService] to marry Anais and Jordana
//Person.MarryTwoPersons(anais, jordana);
//Person.MarryTwoPersons(anais, jordana);

//anais.MarryAPerson(jordana);
//jordana.MarryAPerson(anais);

//anais.WriteToConsole();
//jordana.WriteToConsole();

// 1. add old-school non-generic hash
// 2. add new-school generic hash

System.Collections.Hashtable my_hash_tbl = new();
my_hash_tbl.Add(1, "aaa");
my_hash_tbl.Add(2, "bbb");
my_hash_tbl.Add(3, "ccc");
my_hash_tbl.Add(kim, "ddd");
Console.WriteLine();
int chosen_key = 3;
Console.WriteLine($"mate_key'{chosen_key}' has value: '{my_hash_tbl[chosen_key]}'");
Console.WriteLine($"mate_key'{kim}' has value: '{my_hash_tbl[kim]}'");

//Dictionary<int, string> my_dict = new();
//my_dict.Add(1, "aaa");
//my_dict.Add(2, "bbb");
//my_dict.Add(3, "ccc");
//my_dict.Add(kim, "ddd");
//Console.WriteLine();

//Console.WriteLine($"mate_key'{chosen_key}' has value: '{my_dict[chosen_key]}'");
//Console.WriteLine($"mate_key'{kim}' has value: '{my_dict[kim]}'"); // error :
//generic has type check


try
{
    anais.WriteKidsToConsole();
    kim.WriteKidsToConsole();
    Person.MakeBabies(anais, kim);
}
catch (Exception e)
{
    Console.WriteLine("[Exception 1] e.Message: {0}", e.Message);
    //Person.Marry(anais, kim);          // WORKS
    _ = anais + kim;
    //Person.MakeBabies(anais, kim);     // WORKS
    _ = anais * kim;

}
finally
{
    anais.WriteKidsToConsole();
    kim.WriteKidsToConsole();
}

// generics vs non-gen:
// [1][non-generic] A old-school datatype
// - import via system...dictionary
// - but not is type-safe, [mate_key can be any type]
//      - ie 1 or "1" or an [object]
// - ie compiler or ide does not strict types inside it?

Console.WriteLine("GEN VS NON-GEN");
System.Collections.Hashtable mate_nongen_hashtbl = new();
mate_nongen_hashtbl[0] = "zero";
mate_nongen_hashtbl[1] = "one";
mate_nongen_hashtbl[kim] = "cool beans";

Console.WriteLine("NON-GEN: Hashtable");
foreach (var mate_key in mate_nongen_hashtbl.Keys)
{
    Console.WriteLine($"key '{mate_key}' (keytype '({mate_key.GetType()})'): value '{mate_nongen_hashtbl[mate_key]}'");
}


// [2][generics] new school datatype
// - type safe
// - no import required   
Console.WriteLine("NON-GEN: Dictionary<int,str>");
Dictionary<int, string> mate_gen_dct = new();
mate_gen_dct[0] = "zero";
mate_gen_dct[1] = "one";
mate_gen_dct[anais.Children.Count] = "cool beans";

foreach (var mate_key in mate_gen_dct.Keys)
{
    Console.WriteLine($"key '{mate_key}' (keytype '({mate_key.GetType()})'): value '{mate_gen_dct[mate_key]}'");
}

Console.WriteLine("4. DELEGATES\n");

// [0] add object (Program.cs):                         [kim]                               - [done]
// [1] add delegate (Person.cs) [done]                  [kim.MyPersonDelegate()]                - [done]
// [2] add method-1: sig matches delegate  (Person.cs)  [kim.MyPersonObjPrintMeMethodViaDG]     - [done]
// [3] add method-2: sig matches delegate  (Person.cs)  ...
// [4] create delegate instance (Program.cs)

MyPersonDelegate dome_kim_dg = kim.MyPersonObjPrintMeMethodViaDG;
dome_kim_dg("ran custom dome_kim_dg() which was declared via: MyPersonDelegate dome_kim_dg = kim.MyPersonObjPrintMeMethodViaDG;");
// [5] add method to delegrate instanace (Program.cs)
// [6] run delegate instanace (Program.cs)


Console.WriteLine();
Console.WriteLine("Using DG_MyMsgHandler...");
DG_MyMsgHandler msg_handler_dg = kim.EmailMsg;
msg_handler_dg += kim.LogMsg;
msg_handler_dg("this is single input name");

Console.WriteLine();
string curr_str = "     ";

Console.WriteLine($"Running Delegate on '{curr_str}'...");
//public delegate void DG_VOIDSTR_STR_VALIDATOR_Handler(string some_str);
DG_VOIDSTR_STR_VALIDATOR_Handler cool_hdlr1 = kim.STRSTR1_getlen_DG;
DG_VOIDSTR_STR_VALIDATOR_Handler cool_hdlr2 = new(kim.STRSTR1_getlen_DG);
var cool_hdlr3 = new DG_VOIDSTR_STR_VALIDATOR_Handler(kim.STRSTR1_getlen_DG);

cool_hdlr1("mate1");
cool_hdlr2("mate2");
cool_hdlr3("mate3");

// v1: implict
//public delegate void dg_void_str_hdlr(string some_str);
//DG_VOIDSTR_STR_VALIDATOR_Handler str_val_hdler = new(kim.STRSTR1_getlen_DG);
//str_val_hdler += kim.STRSTR2_isnullorempty_DG;
//str_val_hdler += kim.STRSTR3_isnullorws_DG;
//str_val_hdler(curr_str);

//GreetingDelegate d = new GreetingDelegate(SayHello);             -- gpt
//GreetingDelegate greetingMethod;                                 -- grok
//var greeter = new Greeter(p1.SayHello);  // Same as: new(p1.SayHello)
//var greeter = new Greeter(new GreetingDelegate(p1.SayHello));
//dg_void_str_hdlr str_hdlr = p1.SomeMethod;
//dg_void_str_hdlr lambdaHdlr = name => Console.WriteLine(name);
//Console.WriteLine("PROGRAM ENDED");
//


// create DG instance pointed at Person.method
DGInt_MethStr DGInt_MethStrHandler = new(kim.TODG_Int_MethStr);
Console.WriteLine($"DGInt_MethStrHandler: {DGInt_MethStrHandler}");
Console.WriteLine($"DGInt_MethStrHandler.GetType(): {DGInt_MethStrHandler.GetType()}");

Console.WriteLine("Ran delegrate instance: DGInt_MethStrHandler('tonycules')...");
DGInt_MethStrHandler("tonycules");

//kim.SayMyName("tony abalone");

DG_VD_STR_SayMyNameHandler name_handler = new(kim.SayMyName);
name_handler("tony cules");

//public delegate void DG_VD_STR_Handler(string some_str);
DG_VD_STR_Handler vd_str_hdler_1;

void TalkShiz(string name) { Console.WriteLine($"what up, {name}!"); }
;
void TalkShiz2(string name) { Console.WriteLine($"what up, {name}!"); }
;

vd_str_hdler_1 = TalkShiz;
vd_str_hdler_1 += TalkShiz2;
Console.WriteLine($"vd_str_hdler_1.GetType(): vd_str_hdler_1.GetType(): {vd_str_hdler_1.GetType()}");


vd_str_hdler_1.Invoke("mi chiamo tony!");

//public DG3_EVHDLR? DG3_ShoutAtMe; // a nullable [field] with [delegate-type]

// 1. instance field setup ----- // [Field] = Anon_Fn(Sender? sender, EventArgs e) => cw("mate");      

// 2. instance field calling
//kim.DG3_ShoutAtMe();
//kim.DG3_ShoutAtMe();


// [[[ Goal ]]]
// 1. add   [dg.cs] delegate pre-def'n:   EventHandler, EventHandler<...> - DONE
// 2. add   [ps.cs] delegate type-field:    Shout;
// 3. add   [pg.cs] delegate invokation:

//kim.;

// [pers.cs]: 
// [ testing ]
// 1. SETUP:    create person instance p // kim
// 2. NULL:     p.Shout will be null, test if ull
//try
//{
//    //kim.Shout.Invoke(kim,EventArgs.Empty); // works but null is NullReferenceException
//    kim.Shout?.Invoke(kim, EventArgs.Empty); // works and skips null instead of exception
//}
//catch (Exception e)
//{
//    Console.WriteLine($"tp error: {e}");
//}
//finally
//{
//    Console.WriteLine("[----------- shout ended -----------]");
//}

// 3. ASSIGN:   p.Shout = method, allocate some method following shape (sender, e)
// 4. RUN:      p.shout() run it\

// 1. [pers.cs] add EventHandler {EH}
// 2. [pers.cs] add field [Shout]     - {EH_instance)
// 3. [pers.cs] add field [AngerLvl]  - int
// 4. [pers.cs] add methd [Poke()]    - void: incr [Anger], calls EH_instance() -> calls [atta ched-methods]

//kim.Poke();
//kim.Poke();
//kim.Poke();
//kim.Poke(); /// reset

//// attach a method to AngryEventHandler
//kim.AngryShouts += ShoutAtYou;
//kim.Poke();
//kim.Poke();
//kim.Poke();
//kim.Poke(); /// reset

//static void ShoutAtYou(object? sender, EventArgs e) 
//{
//    Console.WriteLine($"hey {sender}, bugger off you!"); 
//};


// 4.a  add [lgc][pro.cs] SS_SH_obj & Pers_obj
// 4.b  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times
// 4.c  add [lgc][pro.cs] SS_SH_obj +- Mth
// 4.d  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times
//Console.WriteLine();
//kim.Punch(anais);
//kim.Punch(anais);
//kim.Punch(anais);
//kim.SuperSayanify += SuperSayanReached;
//Console.WriteLine();
//kim.Punch(anais);
//kim.Punch(anais);
//kim.Punch(anais);
//Console.WriteLine();
//kim.Punch(anais);
//kim.Punch(anais);
//kim.Punch(anais);


//void SuperSayanReached(object? sender, EventArgs e)
//{
//    //Console.WriteLine($"{sender} has reached SuperSayan Mode!");
//    if (sender is null)
//    {
//        Console.WriteLine("sender is null");
//        return;
//    }

//    //Person? p = sender as Person;  // reuturns Persons or null
//    //Person? p = sender as Person;  // reuturns Persons or null
//    if (sender is not Person p) return;
//    Console.WriteLine($"{p?.Name} has reached SuperSayan Mode!");
//}

// create list of person
// run Person.OutputPersonNames(list_of_ppl)
//List<Person?> real_ppl = new()
//{
//    Person james = new()

//};
//Person?[] ppl = {
//    new("mate", new DateTimeOffset()),
//    null,
//    new("cuz",  new DateTimeOffset()),
//    new(null,  new DateTimeOffset()),
//    new("legend",  new DateTimeOffset()),
//};

//Person.OutputPersonNames(ppl);
//Array.Sort(ppl);    // wihtout IComparable
//                    // Unhandled exception. System.InvalidOperationException: Failed to compare two elements in the array.
//                    // ---> System.ArgumentException: At least one object must implement IComparable.
//Person.OutputPersonNames(ppl);

kim.StrikeOut();
kim.StrikeOut();
kim.StrikeOut();
kim.StrikeNoHandler += YoureOutProg;
kim.StrikeNoHandler += kim.YoureOutP1;
kim.StrikeOut();
kim.StrikeOut();
kim.StrikeOut();

void YoureOutProg(object? sender, EventArgs e)
{
    if (sender is not Person p) return;

    StrikeEventArgs? se = e as StrikeEventArgs;
    Console.WriteLine($"{p.Name} has striked out, Strike {se?.StrikeNo} [prog.cs]");
}