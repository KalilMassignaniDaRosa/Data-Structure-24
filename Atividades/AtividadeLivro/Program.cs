using System.Diagnostics;
using AtividadeLivro;

List<Book>  books = new List<Book>();
Book b1 = new Book(){
    Name = "Man and His Symbols",
    Author = "Carl Jung",
    Publisher = "Dell",
    NumberPage = 432,
};

Book b2 = new Book(){
    Name = "Listen, Little Man!",
    Author = "Wilhelm Reich",
    Publisher = "Farrar, Straus and Giroux",
    NumberPage = 144,
};

Book b3 = new Book(){
    Name = "Harry Potter and the Philosopher's Stone",
    Author = "J. K. Rowling",
    Publisher = "Bloomsbury",
    NumberPage = 309,
};

Book b4 = new Book(){
    Name = "The Bad Beginning (A Series of Unfortunate Events #1)",
    Author = "Daniel Handler",
    Publisher = "HarperCollins",
    NumberPage = 162,
};

Book b5 = new Book(){
    Name = "The 48 Laws of Power",
    Author = "Robert Greene",
    Publisher = "Penguin Books",
    NumberPage = 452,
};

int biggiestNumber = 0;
int index = 0;
books.Add(b1);
books.Add(b2);
books.Add(b3);
books.Add(b4);
books.Add(b5);

for(int i = 0; i < books.Count; i++){
    if(books[i].NumberPage > biggiestNumber){
        biggiestNumber = books[i].NumberPage;
        index = i;
    }
}


Console.WriteLine("==================================");
Console.WriteLine($"Name: {books[index].Name}");
Console.WriteLine($"Author: {books[index].Author}");
Console.WriteLine($"Publisher: {books[index].Publisher}");
Console.WriteLine($"Number of Pages: {books[index].NumberPage}");
Console.WriteLine("==================================");