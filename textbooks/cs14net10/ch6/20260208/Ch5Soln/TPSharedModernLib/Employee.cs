
namespace TPSharedModernLib;

public class Employee : Person
{
    public int EmployeID;
        
    public new void WriteToConsole()
    {
        WriteLine("{0} has employee id: {1}", Name, EmployeID);
    }

    #region Overriden Methods
    public override string? ToString()
    {
        return $"{Name} is my name with id: '{EmployeID}' [{base.ToString()}]!";
        //return base.ToString(); // og
    }
    #endregion
}

