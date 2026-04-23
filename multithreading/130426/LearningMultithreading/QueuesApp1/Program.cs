using System.Linq;

Queue<int> q = new();
Queue<int> processed_q = new();
int ticket_no=0;
Thread monitor_thread = new Thread(MonitorQueue);
monitor_thread.Start();
while (true) 
{
    Console.Write("\nTicketing-Web-Server is running...('b' buy new ticket, 'c' cancel ticket, 'l' list)");
    string? input_str = Console.ReadLine();
    if (input_str is null) break;
    if (input_str.ToLower() == "b")
    {
        ticket_no++;
        q.Enqueue(ticket_no); 
        Console.WriteLine($"Allocating ticket: {ticket_no}");
    }
    else if (input_str.ToLower() == "c")
    {
        Console.WriteLine($"Type in your Ticket_No (integer):  ");
        int.TryParse(Console.ReadLine(), out int input_ticket_no);
        if (processed_q.Contains(input_ticket_no))
        {
            Console.WriteLine("deleted (fake)");
            int[] processed_arr = processed_q.ToArray();

            processed_arr[processed_arr.IndexOf(input_ticket_no)] = 0;
            processed_q = new Queue<int>(processed_arr);
        }
    } else if (input_str.ToLower() == "l")
    {
        Console.WriteLine("Processed tickets:");
        foreach (var processed_i in processed_q)
        {
            Console.WriteLine($"- {processed_i}");
        }
    }
}

void MonitorQueue()
{
    while (true)
    {
        Thread.Sleep(500);
        if (q.Count>0)
        {
            Thread thread = new Thread(() => ProcessSingleRequestItem(q.Dequeue()));
            thread.Start();
        }
    }

}

void ProcessSingleRequestItem(int q_i)
{
    Thread.Sleep(2000);
    Console.WriteLine($"Ticket Allocated Succesfully: {q_i}");
    processed_q.Enqueue(q_i);
    //processed++;
    //Console.WriteLine($"'{q_i}' processed. [{processed}]");
    Console.WriteLine($"'{q_i}' processed (fake)");
}


// methods:

// - Enqueue()
// - Dequeue()
// - Contains()
// - Peek()
// - Count()
// - Queue.ToArray()
