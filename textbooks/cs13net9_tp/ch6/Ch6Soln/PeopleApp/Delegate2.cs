using System.Runtime.InteropServices.JavaScript;
using System.Threading;
using TP.SharedLibraries;

namespace PeopleApp
{
    public delegate void DG_VDSTR_SAYHI(string some_str); //custom (not best practice)

    public delegate void DGEventHandler(object? sender, EventArgs e);
    public delegate void DGEventHandler<TEventArgs>(object? sender, TEventArgs e);
}

// [1. create delegate]
// 1a. - no args
// 1b. - args

// [2. empty args]
// 2a. - 
// 2a. - [EventArgs.Empty] is empty EventArgs value.
//     - For [built-in event delegates] requiring [EventArgs] instance passed as a parameter


// [3. call delegate] examples
// 3a. - variable name
// 3b. - Invoke()


// [4. scenario]
// Add Person class:
// 4a.  defines an [EventHandler] [delegate] [field] named 'Shout'.
// 4b.  defines an int [field] to store [AngerLevel].
// 4c.  defines a (method) named 'Poke'.
// 4d.  Each time a person is poked, their [AngerLevel] [increments].
// 4e.  Once their [AngerLevel] reaches [3], they raise the [Shout] {event},
// but only if there is at {least one event delegate} <pointing> at a [method]
// defined somewhere else in the code; that is, it is [not null]: