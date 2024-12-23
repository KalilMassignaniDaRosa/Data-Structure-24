using Lotery;

LoteryQueue queue = new LoteryQueue();

// Adicionando pessoas à fila
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