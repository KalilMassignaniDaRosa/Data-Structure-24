// Uma Enqueue é a estrtutura de dados que pode ser aplicada para representar a Enqueue de atendimento da cantina
// As pessoas que chegam entram no final da Enqueue e as primeiras que chegaram são as primeiras a serem atendidas

// A Função Enqueue é reponsável por adicionar novos elementos a Enqueue
// A Função DEQUEUE remove elementos da Enqueue
// Desta formam, obedece o principio do FIFO
// First In, First Out

using Enqueues;

Random random = new Random();

// Possivel simplificar usando apenas new
CallCenter center = new();
center.Call(1234);
center.Call(1369);
center.Call(2468);
center.Call(1478);

while(center.AreWaitingCalls()){
    // Milisegundos
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(@$"
    Call started at: {DateTime.Now.ToString("HH:mm:ss")}
    Call: #{call.Id}
    From: {call.ClientId} 
    Served by: {call.Consultant}");
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(@$"
    Call: {call.Id} 
    Ended at {call.EndTime.ToString("HH:mm:ss")}");
}