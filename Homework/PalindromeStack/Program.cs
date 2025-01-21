Console.WriteLine("Insert a word: ");
string? word = string.Empty;
word = Console.ReadLine();
string? inverse = string.Empty;

Stack<char> caracters= new Stack<char>();

// Preenchendo pilha com os caracteres
foreach (char c in word!)
{
    caracters.Push(c);
}

// Reconstruindo a stack invertida
while (caracters.Count > 0)
{
    inverse += caracters.Pop();
}

Console.WriteLine("Original: "+word);
Console.WriteLine("Inverse: "+inverse);

if (word.Equals(inverse, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("Isn't a palindrome");
}