
namespace PeopleApp;
// create a delegate
// - int fn(string){}

public delegate int DGInt_MethStr(string some_str);
// declares a type/class delegate:
// - portraying a method signature
// - a signature that matches existing signatures
// - thus if subscribed to this delegate
// - this subscribed fn will run if the delegate is run.
// - can be instantiated and methods can be attached/subbed


public delegate void DG_VD_STR_SayMyNameHandler(string name); //

//public delegate void EventHandler(object? sender, EventArgs e);
//public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);

//public delegate void DG_VD_STR_Shout(string some_str_to_shout);
//public delegate void DG_BASIC_1();

public delegate void EventHandler(object? sender, EventArgs e);
public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);


// public delegate void DG_VD_STR_Hanlder(string some_str);
// 1.  create delegate: which is a type, must be instantiated to be 'used'?
// 2.  instantiate dg_instance
// 2a. - null   instantiation
// 2b. - method instantiation


public delegate void DG_VD_STR_Handler(string some_str);


//public delegate void EvHdlr()


