// Basicamente Stacks trabalham com uma estrutura LIFO
// LIFO = Las In First Out
// Tres metodos importantes:
// Push() -> Insere um elemento no topo da pilha
// Pop() -> Remove um elemento do topo e o retorna
// Peek() -> Retorna o elemento do topo sem remove-lo

// Invertendo
Stack<char> caracteres = new Stack<char>();
foreach (char c in "DARCY DA MONTANHA"){
    caracteres.Push(c);
}

// Desempilhando
string inverse = string.Empty; 
while(caracteres.Count > 0){
    inverse += caracteres.Pop();
}

Console.WriteLine(inverse);