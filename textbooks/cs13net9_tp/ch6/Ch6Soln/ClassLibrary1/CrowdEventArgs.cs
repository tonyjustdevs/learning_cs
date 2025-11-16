namespace TP.SharedLibraries;

public class CrowdEventArgs : EventArgs
{
    public int PersonCount;
    public CrowdEventArgs(int Person) 
    {
        PersonCount=Person;
    }
}

// --------------- ThreesACrowd Logic --------------- //
// [1]  [pers.cs] add {field} (event) CrowdEventHandler
// [2]  [pers.cs] add {field} (int) PersonCounter;
// [3]  [pers.cs] add {method} AddPerson():
// [3a] [pers.cs] - PersonCounter++
// [3b] [pers.cs] - runs EventHandler() (runs all attached methods)
// [4]  [prog.cs] add Person instance
// [5]  [prog.cs] attach method to += CrowdEventHandler
// [6]  [prog.cs] run Person.AddPerson()
// [6]  [prog.cs] run Person.AddPerson()
// [7]  [prog.cs] validate results

