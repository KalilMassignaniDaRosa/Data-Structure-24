using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas{
    //Esta classe representa a fila de chamados em um Call Center
    public class IncomingCall{
        //Snipped
        //prop
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String? Consultant { get; set; }

    }
}