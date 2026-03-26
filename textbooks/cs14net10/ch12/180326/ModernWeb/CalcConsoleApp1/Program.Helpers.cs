namespace CalcConsoleApp1;

partial class Program
{

    //Action<Order>
    //Action<Order> onSuccess = o => Console.WriteLine(o.Id);
    //Action<Order> onSuccess = new Action<Order>(GeneratedMethod);
    //Action<Order> onSuccess = new Action<Order>(GeneratedMethod);
}

// Explaining:
// - Action<Order> onSuccess = emailService.Send;"x
//
// 1. what is Action<Order>
// It is a type: delegate void Ation(Order obj)
// - takes Order and returns nothing (void)

// 2. What is emailService.Send
// - object.method
// - here is adAction<Order> onSuccess = o => Console.WriteLine(o.Id);`
