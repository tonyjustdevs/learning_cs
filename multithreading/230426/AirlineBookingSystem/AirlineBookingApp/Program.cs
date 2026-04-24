using System.Diagnostics;

Console.WriteLine("Running Airline Booking System...");
object booking_lock = new();
// web server:
// - [main_thread]
//      - adds requests to [queue]
// - [monitor_thread] 
//      - watches [queue] -> deque to [processing_thread]
// - [processing_thread]
int available_seats=10;
Queue<string> global_queue = new();
Thread monitoring_thread = new Thread(Monitor);
monitoring_thread.Start();

while (true)
{
    Console.WriteLine("'b' booking or 'c' cancel");
    var input_str = Console.ReadLine()!.ToLower();
    global_queue.Enqueue(input_str);
}

void Monitor()
{
    while (true)
    {
        if (global_queue.Count>0)
        {
            var current_request = global_queue.Dequeue();
            ProcessBooking(current_request);
        }
        Thread.Sleep(100);
    }
}

void ProcessBooking(string book_or_cancel)
{
    lock (booking_lock) { 
        if (book_or_cancel == "b")
        {
            Thread.Sleep(100);
            available_seats--;
            Console.WriteLine($"Booking confirmed! Available seats: {available_seats}");
        }
        else if (book_or_cancel == "c")
        {
            Thread.Sleep(100);
            available_seats++;
            Console.WriteLine($"Booking cancelled! Available seats: {available_seats}");
        }
    }
}
