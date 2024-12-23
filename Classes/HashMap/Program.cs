//Exemplo de uma agenda telefônica

using System.Collections;

Hashtable phoneBook = new Hashtable(){
//    {"Chave","Valor"},
    {"Thomazzi","49-9961-0150"},
    {"Mauricio Gonzatto", "49-99975-8575"},
    {"Gabriel Bianchi","49-99105-8904"}
};

//É possivel adicionar elementos de diversas formas
//Pelo proprio do indice chave inexistente
phoneBook["Thiago Padilha"] = "49-99175-8255";

//Ou pelo metodo Add()
phoneBook.Add("Marcos Henrique","49-99202-6169");

//Entretanto, a tabela hash verifica se ha duplicidade de chave e pode lançar uma Exception 
try{
    phoneBook.Add("Mauricio Gonzatto","49-99975-8575");
}catch(Exception ex){
    Console.WriteLine($"Error trying include repeated value");
    Console.WriteLine(ex.Message);
}

//Percorrendo itens da HashTable
Console.WriteLine("Phone Book:");
//Tirado {} para melhor leitura pois tem apenas uma instrução cada
//Não altera performace
if(phoneBook.Count == 0)
    Console.WriteLine("Phone Book is empty");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}: {entry.Value}");