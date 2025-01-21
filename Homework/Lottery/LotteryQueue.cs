using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lottery{
    public class LotteryQueue{
        private Stack<Ticket> stack = new Stack<Ticket>();
        private Stack<Ticket> stackAux = new Stack<Ticket>();
        private int nextTicketNumber = 1;

        // Metodo para gerar um novo ticket e colocar na fila
        public void Enqueue(){
            Ticket newTicket = new Ticket(nextTicketNumber);
            stack.Push(newTicket);
            Console.WriteLine($"Ticket #{newTicket.Number} joined the queue");
            nextTicketNumber++;
        }

        // Metodo para remover o proximo ticket da fila
        public Ticket Dequeue(){
            if (IsQueueEmpty()){
                return null!;
            }

            // Transferir os elementos da stack para a stackAux (invertendo a ordem)
            while (stack.Count > 0){
                stackAux.Push(stack.Pop());
            }

            // Remover o ticket do topo da stackAux 
            Ticket dequeuedTicket = stackAux.Pop();

            // Transferir os elementos de volta para a stack
            while (stackAux.Count > 0){
                stack.Push(stackAux.Pop());
            }

            Console.WriteLine($"Ticket #{dequeuedTicket.Number} was served and left the queue");
            return dequeuedTicket;
        }

        // Metodo para verificar se a fila esta vazia
         public bool IsQueueEmpty(){
        if (stack.Count == 0){
                Console.WriteLine("The queue is empty.");
                return true;
            }
        return false;
        }

        // Metodo para mostrar o proximo ticket da fila sem remove-lo
        public Ticket Peek(){
            if (IsQueueEmpty()){
                return null!;
            }

            // Transferir os elementos da stack para a stackAux para acessar o primeiro da fila
            while (stack.Count > 0){
                stackAux.Push(stack.Pop());
            }

            Ticket firstTicket = stackAux.Peek();

            // Transferir os elementos de volta para a stack
            while (stackAux.Count > 0){
                stack.Push(stackAux.Pop());
            }

            Console.WriteLine($"The next ticket to be served is number #{firstTicket.Number}");
            return firstTicket;
        }

        // Metodo Timer para introduzir atrasos aleatosrios
        public void Timer(){
            Random random = new Random();
            Thread.Sleep(random.Next(1000, 10000));
        }
    }
}