namespace TPSharedNamespace;

public class Customer
{
    public string? name { get; set; }
    public int age { get; set; }

// static method: update customer age
    public static void UpdateAge(Customer? cus, int new_age)
    {
        cus?.age = new_age; // do nothing if cus is null
    }
    public static void UpdateAge2(Customer? cus, int new_age)
    {
        if (cus is not null) // same but longer
        {
            cus.age = new_age;
        }
    }
   

}
