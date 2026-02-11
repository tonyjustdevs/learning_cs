using System.Reflection;

namespace TPSharedModernLib;

public class PersonalException : Exception
{
    public PersonalException() : base() { }
    public PersonalException(string? message) : base(message) { }
    public PersonalException(string? message, Exception? innerException):base(message, innerException) { }

}


    
