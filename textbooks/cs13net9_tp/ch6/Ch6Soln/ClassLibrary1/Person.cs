namespace TP.SharedLibraries;
public partial class Person
//public partial class Person : IComparable<Person?>
{

    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset? DOB { get; set; }
    public List<Person> Children { get; set; } = new();
    public List<Person> Spouses { get; set; } = new();
    #endregion
    public bool isMarried => Spouses.Count > 0;
    public int SpousesCount => Spouses.Count;
    public bool isMarried2 { get { return Spouses.Count > 0; } }
    public Person() { }
    public Person(string? name, DateTimeOffset dob)
    {
        Name = name;
        DOB = dob;
    }
    #region InstanceMethods
    public void WriteToConsole() => Console.WriteLine(
        $"'{Name}' " +
        $"was born a '{DOB:dddd}' " +
        $"& has '{SpousesCount}' spouse(s).' ");

    public void WriteKidsToConsole()
    {
        string kids_term = Children.Count() == 1 ? "kid" : "kiddos";
        Console.WriteLine($"'{Name}' has {Children.Count()} {kids_term}.'");
    }
    #endregion

    #region StaticMethods
    public static void Marry(Person p1, Person p2)
    {
        Console.WriteLine("A Marry() ceremony is happening...");
        // 1. raise exception if null
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        // 2. check if p1 & partner already married
        if (p1.Spouses.Contains(p2) | p2.Spouses.Contains(p1))
        {
            Console.WriteLine("{0} & {1} are alreday hitched!", p1, p2);
        }
        else
        {
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }
    }
    public void Marry(Person partner)    // instance method
    {
        Marry(this, partner);
    }

    #endregion

    #region Marriage
    static public void HitchTwoPersons(Person p1, Person p2)    // static method
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (p1.Spouses.Contains(p2) | p2.Spouses.Contains(p1))
        {
            Console.WriteLine("already hitched them!");
        }
        else
        {
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }
    }
    #endregion

    #region MakeBabies
    public static void MakeBabies(Person p1, Person p2)
    {
        Console.WriteLine("MakeBabies() attempted...");
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (!p1.Spouses.Contains(p2) & !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException($"'{p1.Name}' & '{p2.Name}' must be MARRIED before making babies!");
            // [test-1] make 2 persons and make babies ---> [exp] error!
        }
        else
        {
            Console.WriteLine("babies made");
            Person bb = new() { Name = "bb1_p1p2", DOB = DateTimeOffset.Now };
            p1.Children.Add(bb);
            p2.Children.Add(bb);
        }
    }
    #endregion

    #region Operators
    public static bool operator +(Person p1, Person p2)
    {
        Console.WriteLine("'+' Operator -> Marry() run....");
        Marry(p1, p2); //[test-2] use + operator to perform marriage ceremony
        return true;
    }
    #endregion

    public static bool operator *(Person p1, Person p2)
    {
        Console.WriteLine("'*' Operator -> MakeBabies() run....");
        MakeBabies(p1, p2);
        return true;
    }

    public delegate void MyPersonDelegate(string? im_a_string);
    public void MyPersonObjPrintMeMethodViaDG(string? my_string_param)
    {
        Console.WriteLine($"{my_string_param}");
    }

    public delegate void DG_MyMsgHandler(string some_msg);

    public void EmailMsg(string email) => Console.WriteLine($"Email Content: '{email}'");
    public void LogMsg(string logs) => Console.WriteLine($"Logged Text: '{logs}'");

    public delegate void DG_VOIDSTR_STR_VALIDATOR_Handler(string some_str);
    public void STRSTR1_getlen_DG(string some_str)
    { //Console.WriteLine("{index,alignment:format}", value);
        //Console.WriteLine($"'{some_str}' has length: '{some_str.Length}'");
        //Console.WriteLine("{0,-15} {1,-10} {2,-15:C2}", "Alice", 30, 55000.75);
        Console.WriteLine("'{0}' {1,-20} {2,10}", $"{some_str}", "has length:", some_str.Length);
    }
    public void STRSTR2_isnullorempty_DG(string some_str)
    {
        Console.WriteLine("'{0}' {1,-20} {2,10}", $"{some_str}", "is null or empty:", string.IsNullOrEmpty(some_str));
        //Console.WriteLine($"'{some_str}' is null or empty: '{string.IsNullOrEmpty(some_str)}'");
    }
    public void STRSTR3_isnullorws_DG(string some_str)
    {

        Console.WriteLine("'{0}' {1,-20} {2,10}", $"{some_str}", "is null or white-space:", string.IsNullOrWhiteSpace(some_str));
    }
    public int TODG_Int_MethStr(string some_str)
    {
        Console.WriteLine($"'{some_str}' length: {some_str.Length}");
        return some_str.Length;
    }
    public void SayMyName(string name)
    {
        Console.WriteLine($"Your name is: {name}");
    }
    //public EventHandler? Shout;
    //instance field that is a delegate
    //a delegate a type

    //a delegate can be instantiated as an instance of the delegate type following a certain method sigh

    //interestingly unlike other instances, which uses the.dot operator to access other methods() to run
    //a delegate instance itself is runnable with parenthesis, thats quite unique right?
    // is some method signature template that any other method can subscribe to

    // normallly an delegate is something like:
    //public void GreetName(string name) => Console.WriteLine($"Hello {name}");

    // create field of type delegate
    //public DG3_EVHDLR? DG3_ShoutAtMe; // a nullable [field] with [delegate-type]

    // add delegate field;
    //TPEventHandler? ShoutHandlerArgFree1;  // ok null but invocation requires invoke?...
    TPEventHandler ShoutHandlerArgFree2 = (mate, sup) => { }; // anon fn ok

    // normally in [prog.cs]: person.ShoutHandlerArgFree();
    // but to call ShoutHandlerArgFree with another function
    // use:

    //void doShout1()
    //{
    //    ShoutHandlerArgFree1?.Invoke(this, EventArgs.Empty); // Nullable field

    //}

    void doShout2()
    {
        ShoutHandlerArgFree2(this, EventArgs.Empty); // non-null field (initialised)

    }

    // add delegate event handler
    // Write function that runs delegates
    // add field [eventhandler]
    // add methd[eventhndler_runner()] that runs it: eventhandler()

    // - a field of a [type Person]
    // - [type TPEH] instnace allowed to be null
    // - accepts (object? sender, EventArgs e)
    // [prog.cs]: it can be invoked person.Shout(); (if already inc matching-methods)

    // 
    // [pers.cs]: 
    // [ testing ]
    // 1. SETUP:    create person instance p
    // 2. NULL:     p.Shout will be null, test if ull
    // 3. ASSIGN:   p.Shout = method, allocate some method following shape (sender, e)
    // 4. RUN:      p.shout() run it
    //public void TPEventHandlerRunner()
    //{

    //}

    public TPEventHandler? Shout;

    // why do we need to write a function to run shout?


    public void RunShout()
    {   // Shout must have be: (object? sender, EventArgs e);
        Console.WriteLine($"[{this.Name}] is running RunShout()");
        Shout?.Invoke(this, EventArgs.Empty); // nothing should happen
    }

    // 1. [pers.cs] add EventHandler {EH}
    // 2. [pers.cs] add field [Shout]     - {EH_instance)
    // 3. [pers.cs] add field [AngerLvl]  - int
    // 4. [pers.cs] add methd [Poke()]    - void: incr [Anger], calls EH_instance() -> calls [atta ched-methods]

    public delegate void AngerEventHandler(object? sender, EventArgs e);
    public delegate void AngerEventHandler<TEventArgs>(object? sender, EventArgs e);

    public AngerEventHandler? AngryShouts;
    public int AngerLevel;
    public void Poke()
    {
        AngerLevel++;
        Console.WriteLine($"{this.Name} got Poked! Anger Level: {AngerLevel}");
        if (AngerLevel <= 3)
        {
            return;
        }

        AngryShouts?.Invoke(this, EventArgs.Empty); // call EH instance
        AngerLevel = 0;
        Console.WriteLine($"{this.Name} has calmed down... Anger Level: {AngerLevel}");
        return;

        // create person instance
        // run poke() 4-times
        // 
    }

    public void Poke2(object? sender, EventArgs e)
    {
        if (AngerLevel <= 3) { return; }
        if (sender is not Person p) { return; }

        Shout?.Invoke(this, EventArgs.Empty);

    }

    // 1.   add [fld][per.cs] SuperSayanLevel
    // 2.   add [fld][per.cs] SuperSayanEventHandler
    // 3.   add [mth][per.cs] IncrPower()
    // 3a.  add [lgc][per.cs] SS_L++
    // 3b.  add [lgc][per.cs] if SS_L>3 -> run SS_EH()

    // 4.a  add [lgc][pro.cs] SS_SH_obj & Pers_obj
    // 4.b  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times
    // 4.c  add [lgc][pro.cs] SS_SH_obj +- Mth
    // 4.d  add [lgc][pro.cs] Run Pers_obj.IncrPower() 3-times

    // Interfaces [A]
    // 1a.  add [sta][mth]  OutputPersonNames(Inenumerable<Person?>)
    // 2b.  add [lgc][mth]  for each person ...
    // 3.   add [lgc][mth]  output Name (null logic)

    public static void OutputPersonNames(IEnumerable<Person?> ppl)
    {
        foreach (Person? p in ppl)
        {
            string msg = p is null ? "<null> Person" : p.Name ?? "Name is <snull>";
            Console.WriteLine(msg);
        }
    }

    private int StrikeNo;
    //public event EventHandler? StrikeNoHandler;
    public event EventHandler<StrikeEventArgs>? StrikeNoHandler;
    public void StrikeOut()
    {
        StrikeNo += 1;
        Console.WriteLine($"Hit & A Miss, Strike: {StrikeNo}");
        if (StrikeNo < 2) { return; }
        StrikeNoHandler?.Invoke(this, new StrikeEventArgs(StrikeNo));
        StrikeNo = 0;
        Console.WriteLine($"\nNext Hitter up!");
    }
    public void YoureOutP1(object? sender, EventArgs e)
    {
        Console.WriteLine($"Strike {((StrikeEventArgs)e).StrikeNo}! You're Out! [pers1.cs]");
    }

    public EventHandler? GoalScoreHandler_1; // === public event void ScoreAGoal(object? s, EventArgs e)
    public event EventHandler? GoalScoreHandler_2; // === public event void ScoreAGoal(object? s, EventArgs e)
    public int GoalCount;
    public void ScoreAGoal()
    {
        GoalCount++;
        Console.WriteLine($"{this.Name} scored a goal! Goals: {GoalCount}");
        if (GoalCount % 3 != 0) { return; }
        ;

        // HattrickEvent
        GoalScoreHandler_1?.Invoke(this, EventArgs.Empty);

        // Reset
        //GoalCount = 0;
    }

    // --------------- BEG ThreesACrowd Logic --------------- //
    // [1]  [pers.cs] add {field} (event) CrowdEventHandler
    public event EventHandler? CrowdEventHandler;
    public event EventHandler? CrowdEventHandlerWithArgs;
    public event EventHandler<CrowdEventArgs> CrowdEventHandlerWithArgs2;
    //public event EventHandler<CrowdEventArgs> CrowdEventHandlerWithArgs3;
    //public delegate void EventHandler<CrowdEventArgs> CrowdEventHandlerWithArgs4(Person? person, CrowdEventArgs e);

    // [2]  [pers.cs] add {field} (int) PersonCounter;
    public int PersonCounter;

    // [3]  [pers.cs] add {method} AddPerson():
    public void AddPerson()
    {
        PersonCounter++;                                             // [3a] [pers.cs] - PersonCounter++
        Console.WriteLine($"Person added. People: {PersonCounter}"); // [3b] [pers.cs] - Add PC output
        if (PersonCounter % 5 != 0) { return; }
        ;                     // [3c] [pers.cs] - add req logic to run EventHandler() 
        CrowdEventHandler?.Invoke(this, EventArgs.Empty);            // [3d] [pers.cs] - runs EventHandler() (runs all attached methods)

        //var event_args = new CrowdEventArgs(PersonCounter);                       // v1
        //CrowdEventHandlerWithArgs?.Invoke(this, event_args);                      // v1
        CrowdEventHandlerWithArgs?.Invoke(this, new CrowdEventArgs(PersonCounter)); // v2
        CrowdEventHandlerWithArgs2?.Invoke(this, new CrowdEventArgs(PersonCounter)); // v3
        //CrowdEventHandlerWithArgs3?.Invoke(this, new CrowdEventArgs(PersonCounter)); // v3
        //CrowdEventHandlerWithArgs4?.Invoke(this, new CrowdEventArgs(PersonCounter)); // v3

    }

    public int  ToCompare(Person? other)
    {
        if (other == null) return 1; // non-null > null
        if (Name == null) return other.Name == null ? 0 : -1;
        else
        {
            int instance_value = (Name?.Length??0).CompareTo(other?.Name?.Length??0);
            Console.WriteLine($"instance_value: {instance_value}");
            return instance_value;
        }

    }
    //public override string ToString()
    //{
    //    return Name ?? "<null>";
    //}
    # region OverriddenMethods
    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }
    # endregion
}
