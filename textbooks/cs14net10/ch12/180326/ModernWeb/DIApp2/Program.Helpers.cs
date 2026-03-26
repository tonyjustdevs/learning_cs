using Northwind.EntityModels;
using System.Reflection.Metadata;
partial class Program
{

    //public static void GdayMethod() { }

    
    public static void DoShouterService() {
        Console.WriteLine("\nRunning ShouterService()...");
        Dictionary<Type, Action> TypeActionDict = new();
        
        TypeActionDict.Add(         // dict
            typeof(Shouter),    // run-time value of Shouter, instance of Type?
            () => Console.WriteLine("\nType: 'Shouter' retrieved!") // some lambda or run-time value of Action, aka instance of Action? aka delegate instance
        );

        var action = TypeActionDict[typeof(Shouter)];
        Console.WriteLine($"\nTypeActionDict[typeof(Shouter)] returned " +
            $"Action instance 'action': " +
            $"- {action} [{action.GetType}]");

        Console.WriteLine("\nRunning action()");
        action();
    }


    public static void DoGenericPrintingThing<T>(T t_param)
    {
        Console.WriteLine($"\nDoGenericPrintingThing<T>(T {t_param}):");
        Console.WriteLine($" - {t_param} is a {t_param?.GetType()}");
    }

    public static void DoGenericPrint2<T1,T2>(T1 t1, T2 t2)
    {
        Console.WriteLine($"\nDoGenericPrint2<T1,T2>({t1} {t2}):");
        Console.WriteLine($" - {t1} is a {t1?.GetType()}");
        Console.WriteLine($" - {t2} is a {t2?.GetType()}");
    }

    public static bool IsGenLong<T>(T t_param)
    {
        Console.WriteLine($"\nIsGenLong<T>(T {t_param}) ran:");
        Console.WriteLine($"Type: {t_param?.GetType()}");
        return true;
    }
    //var cat3 = animal_provider.GetAnimal<Cat>();
    public static void GetTAnimal<T>(T t_whatever) 
    {
        Console.WriteLine($"\nGetTAnimal<T>({t_whatever})");
        Console.WriteLine($" - {t_whatever}: {t_whatever?.GetType()}"); 
    }

        public static T GetCatAnimalOnly<T>()
        {
            Console.WriteLine($"GetCatAnimalOnly<{typeof(T)}>:");
            Dictionary<Type, Func<object>> AnimalDict = new();
            AnimalDict.Add(typeof(Cat), () => new Cat()); 
            Func<object>? returned_delegate = AnimalDict[typeof(T)]; // return () => new Cat()
            Console.WriteLine($" - returned_delegate: {returned_delegate}           [type:  {returned_delegate.GetType()}]");
            var returned_from_lambda = returned_delegate();
            Console.WriteLine($" - returned_from_lambda:    {returned_from_lambda}     [type:  {returned_from_lambda.GetType()}]");
            Console.WriteLine($" - (T)returned_from_lambda: {(T)returned_from_lambda}  [type:  {((T)returned_from_lambda).GetType()}]");
            var casted_return_from_lambda = (T)returned_from_lambda;
            return casted_return_from_lambda;
        }


}

// some class.
//
// var ap = new AnimalProvider();
// ap.AddCatContextToAnimalDict();
//var cat = ap.GetTAnimalOnly<Cat>()
//Console.WriteLine(cat);
public class AnimalProvider
{
    // create dictioanary: Type: Object
    //public Dictionary<Type, object> AnimalDict = new();
    public Dictionary<Type, Func<object>> AnimalDict = new();

    public void AddCatContextToAnimalDict() 
    {
        AnimalDict.Add(typeof(Cat), () => new Cat());

    }
    public void AddTContextToAnimalDict<T>(Func<object> lambda_for_creation_of_t)
    {
        //AnimalDict.Add(typeof(Cat), new Cat());
        AnimalDict.Add(typeof(T), lambda_for_creation_of_t);
    }

    public T GetTAnimalOnly<T>()
    {
        Console.WriteLine($"\n\nGetTAnimalOnly<{typeof(T)}>:");

        Func<object>? returned_delegate = AnimalDict[typeof(T)]; // return () => new Cat()
        Console.WriteLine($" - returned_delegate: {returned_delegate}           [type:  {returned_delegate.GetType()}]");
        var returned_from_lambda = returned_delegate();
        Console.WriteLine($" - returned_from_lambda:    {returned_from_lambda}  [type:  {returned_from_lambda.GetType()}]");
        Console.WriteLine($" - (T)returned_from_lambda: {(T)returned_from_lambda}  [type:  {((T)returned_from_lambda).GetType()}]");
        var casted_return_from_lambda = (T)returned_from_lambda;
        return casted_return_from_lambda;
    }

    //public T GetAnimal<T>()
    //{
    //    AnimalDict[T]
    //}
    // var animal_provider = AnimalProvider();
    // animal_provider.AddCatContextToAnimalDict();
    // var cat_object= animal_provider.GetObjectAnimal(typeof(Cat))
    // var cat1 = (Cat)cat_object
    // var cat2 = (Cat)animal_provider.GetObjectAnimal(typeof(Cat))
    // var cat2 = animal_provider.GetAnimal<Cat>()
}
//cat = animal_provider.GetAnimal<Cat>();
//dog = animal_provider.GetAnimal<Dog>();
//T = animal_provider.GetAnimal<T>();
public class Shouter
{

}
public class Cat
{

}
public class Dog
{

}

public interface IAnimal { }  
public class Mouse : IAnimal { }
public class Rat : IAnimal
{ }
//public static void DoSomething<T>() { } 

//GetAnimal<Cat>()
//static 