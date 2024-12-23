Console.WriteLine("Insert a word: ");
string? word = string.Empty;
word = Console.ReadLine();
string? inverse = string.Empty;

Stack<char> caracters= new Stack<char>();
while(caracters.Count > 0){
    inverse += caracters.Pop();
}
Console.WriteLine(word);
Console.WriteLine(inverse);
if(word == inverse){
    Console.WriteLine("It's a palindrome");
}else{
    Console.WriteLine("Isn't a palindrome");
}