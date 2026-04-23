// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml;

Console.WriteLine("Hello to Web Server");
Console.WriteLine("Queue is empty, enter things: ");

// create Ticket Dictionary

var TicketDict = new Dictionary<string, bool>
{
    {"A",true},{"B",true},{"C",true},{"D",true},{"E",true},
    {"F",true},{"G",true},{"H",true},{"I",true},{"J",true},
};

Queue<(string,string)> global_queue = new(); // queue(action, ticket)

Thread monitor_thread = new Thread(Monitor);
monitor_thread.Start();

while (true)
{  
    Console.WriteLine($"Buy 'B' (New Ticket) or 'C' (Cancel Existing): [Thread: {Environment.CurrentManagedThreadId}]");
    var chosen_buy_or_cancel = Console.ReadLine()!.ToUpper();
    Console.WriteLine(chosen_buy_or_cancel);
    while (chosen_buy_or_cancel is not "B" && chosen_buy_or_cancel is not "C")
    {
        foreach (var (ticket_key, ticket_status) in TicketDict)
        {
            Console.WriteLine($"- '{ticket_key}': {(ticket_status == true ? "Available [BUY ME]" : "Not Available [CANCEL ME]")}");
        }
        Console.WriteLine($"Try Again 'B' or 'C': [Thread: {Environment.CurrentManagedThreadId}]");
        chosen_buy_or_cancel = Console.ReadLine()!.ToUpper();
        Console.WriteLine($"Chose: {chosen_buy_or_cancel}");
    }
    foreach (var (ticket_key,ticket_status) in TicketDict)
    {
        Console.WriteLine($"- '{ticket_key}': {(ticket_status==true? "Available [BUY ME]" : "Not Available [CANCEL ME]")}");
    }
    Console.WriteLine($"Choose Ticket ('A' to 'J'): ");
    var chosen_ticket_letter = Console.ReadLine()!.ToUpper();
    if (!TicketDict.ContainsKey(chosen_ticket_letter))
    {
        foreach (var (ticket_key, ticket_status) in TicketDict)
        {
            Console.WriteLine($"- '{ticket_key}': {(ticket_status == true ? "Available [BUY ME]" : "Not Available [CANCEL ME]")}");
        }
        Console.WriteLine("Ticket '{chosen_ticket_letter}' doesn't exist! Pick again:");
        chosen_ticket_letter = Console.ReadLine()!.ToUpper();
    }
    global_queue.Enqueue((chosen_buy_or_cancel, chosen_ticket_letter));
    Console.WriteLine($"Current Queue: {global_queue.Count}");
}
void Monitor()
{   
    while (true) 
    {   
        if (global_queue.Count > 0)                             // check queue
        {   
            var processing_information = global_queue.Dequeue();                             // process queue
            Thread processing_thread = new Thread(() => ProcessBooking(processing_information));
            processing_thread.Start();
        }
        Thread.Sleep(6000);
    }
}

void ProcessBooking((string,string) processing_information)
{
    Console.WriteLine("Trying to {0} Ticket '{1}')",processing_information.Item1 == "B" ? "Buy" : "Cancel", processing_information.Item2);
    Thread.Sleep(1000);
    if (processing_information.Item1 == "B") // buy, 
    {
        //if (TicketDict[processing_information.Item2])                               // see if ticket is available
        if (TicketDict.GetValueOrDefault(processing_information.Item2,false))                               // see if ticket is available
        {
            Console.WriteLine($"Ticket '{processing_information.Item2}' Bought!");  //
            TicketDict[processing_information.Item2] = false; // set ticket to unaviable
            return;
        }
        else
        {
            Console.WriteLine($"Ticket '{processing_information.Item2}' is Not-Available! !");  //
            return;

        }
    }
    else if (processing_information.Item1 == "C")  /// cancelling existing ticket (dict["A"]==false
    {
        //if (!TicketDict[processing_information.Item2])
        if (!TicketDict.GetValueOrDefault(processing_information.Item2,false))
        {
            TicketDict[processing_information.Item2] = true; // set to true to make it available
            Console.WriteLine($"Ticket '{processing_information.Item2}' cancelled!");  //
            return;

        }
        else
        {
            Console.WriteLine($"Ticket '{processing_information.Item2}' isnt owned by anyone!");  //
            return;
        }
    }
}

    // todo: check [chosen_ticket] 
    // - is a (valid) [ticket_key] &&
    // - is a (avail) [ticket_key]
    // now: assume passed valid checks


// Add Assumptions to Application 
// - 10 tickets available [a,b,c,d,e|f,g,h,i,j]:
//   - show tickets [avaiable] to customer
// - when ticket is chosen
//   - ticket is [locked]  

// dictTickets['a': true, 'b': false' ...]
