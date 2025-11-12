using Microsoft.Win32.SafeHandles;

namespace TP.SharedLibraries;

public partial class Person
{

    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset DOB { get; set; }
    public List<Person> Children { get; set; } = new();
    public List<Person> Spouses { get; set; } = new();
    #endregion
    public bool isMarried => Spouses.Count > 0;
    public int SpousesCount => Spouses.Count;
    public bool isMarried2 { get { return Spouses.Count > 0; } }

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
    TPEventHandler? ShoutHandlerArgFree1;  // ok null but invocation requires invoke?...
    TPEventHandler ShoutHandlerArgFree2 = (mate, sup) => { }; // anon fn ok

    // normally in [prog.cs]: person.ShoutHandlerArgFree();
    // but to call ShoutHandlerArgFree with another function
    // use:

    void doShout1()
    {
        ShoutHandlerArgFree1?.Invoke(this, EventArgs.Empty); // Nullable field

    }

    void doShout2()
    {
        ShoutHandlerArgFree2(this, EventArgs.Empty); // non-null field (initialised)

    }

    // add delegate event handler
    // Write function that runs delegates
    // add field [eventhandler]
    // add methd[eventhndler_runner()] that runs it: eventhandler()

    public TPEventHandler? Shout; //
    // this is one just instance of type TPEH that also happens to be null
    // recall all TPEH types accept (object? sender, EventArgs e)
    // its null
    // Shout is a field
    // [prog.cs]: it can be invoked person.Shout(); (if already inc matching-methods)
    // [pers.cs]: 
    public void TPEventHandlerRunner()
    {
        
    }

























}


