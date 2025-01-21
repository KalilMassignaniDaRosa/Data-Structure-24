using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery
{
    public class Ticket
    {
        public int Number { get; private set; }

        public Ticket(int number){
            Number = number;
        }
    }
}