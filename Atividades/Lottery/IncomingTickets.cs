using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lottery;

namespace Lottery{
    public class IncomingTickets{
        public static Ticket GetNewTicked(){
            Ticket ticket  = new(){
                Id = .
            };
            //A atribuição já funciona como setter

            Console.WriteLine($"teste {ticket.Id}");
            return ticket;
        }
    }
}