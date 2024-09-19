using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery{
    public class Ticket{
        private int _counter = 0;
        public int Id { get ; set;}


        public static Ticket GetNewTicked(){
            
            //A atribuição já funciona como setter

            Console.WriteLine($"teste {ticket.Id}");
            return ticket;
        }

    }

    
}