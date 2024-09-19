using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas{
    public class CallCenter{
        //Para atributos privados snake_case
        private int _counter = 0;
        public Queue<IncomingCall>? Calls { get; set; }

        public CallCenter(){
            Calls = new Queue<IncomingCall>();
        }

        //Método para a abertura de chamados
        public void Call(int clientId){
            IncomingCall call = new IncomingCall(){
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
            };
            
            Calls!.Enqueue(call);
        }

        public IncomingCall Answer(string consultant){
            //Validação: verificar se tem atendimentos na fila
            if(Calls!.Count > 0){
                IncomingCall call =  Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }
            return null!;
        }

        public void End(IncomingCall call){
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls(){
            return (Calls!.Count > 0);
        }
    }
}