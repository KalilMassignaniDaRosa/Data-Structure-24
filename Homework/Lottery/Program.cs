using Lottery;

LotteryQueue queue = new LotteryQueue();

// Adicionando pessoas a fila
queue.Enqueue();
queue.Timer();
queue.Enqueue();
queue.Timer();
queue.Enqueue();

queue.Timer();
queue.Peek();
queue.Timer();
queue.Dequeue();
queue.Timer();
queue.Peek();
queue.Dequeue();

// Remover mais uma pessoa da fila
queue.Timer();
queue.Peek();
queue.Timer();
queue.Dequeue();

// Tentativa de remover de uma fila vazia
queue.Dequeue();