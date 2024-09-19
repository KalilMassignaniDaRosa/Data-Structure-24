using Lottery;

Stack<Ticket> tickets = new Stack<Ticket>();
IncomingTickets inTicket = new IncomingTickets();


tickets.Push();


foreach (var t in tickets){
    Console.WriteLine(t.Id);
}