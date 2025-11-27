namespace TP.SharedLibraries;

public class PersonalException : Exception
{
    //v1: base  
    public PersonalException() : base() { }

    //v2: base + msg
    public PersonalException(string message) : base(message) { }

    //v3: base + inner_exception
    public PersonalException(string message, Exception innerException) :
        base(message, innerException)
    { }
}

//public class PersonalException : Exception
//{
//    PersonalException() : base() { }
//    PersonalException(string message) : base(message) { }
//    PersonalException(string message, Exception innerException) : base(message, innerException) { }
//}