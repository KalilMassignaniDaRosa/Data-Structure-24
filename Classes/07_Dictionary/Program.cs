// Diferente da Hashtable, o Dictionary nos permite especificar o tipo de dado que sera utilizado nos pares
// Key -> Value
// Isso nos fornece uma estrutura uma estrutura fortemente tipada

using Dictionary;

Dictionary<string, string> dictionary = new(){
    { "Key 1", "Value 1" },
    { "Key 2", "Value 2" }
};

// Obter valor do dictionary
string val = dictionary["Key 1"];

try{
    val = dictionary["Key 3"];
}catch(Exception ex){
    Console.WriteLine("Error trying get Key 3");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("");
// Verificando se a chave existe antes de acessar para evitar erros de prejuizo de execucao 
if(dictionary.ContainsKey("Key 2"))
    Console.WriteLine($"Key 2 : {dictionary["Key 2"]}");

// Outra forma de obter o valor e evitar erro 
dictionary.TryGetValue("Key 4", out string? value);
if(value != null)
    Console.WriteLine($"Key 4: {value}");

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Key 0"] = "Value 0";

// Percorrer o Dictionary
// Dictionary e uma colecao de chave, valor e par
foreach(KeyValuePair<string, string> kvp in dictionary){
    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}

// Utilizando tipos abstratos de dados com dicionario
Dictionary<int, Person> dicPerson = new Dictionary<int, Person>();
dicPerson.Add(1, new Person(){
    Id = 0, 
    BirthDate = new DateTime(2004,6,28),
    Name = "Kalil Massignani da Rosa"
});
dicPerson.Add(2, new Person(){
    Id = 1, 
    BirthDate = new DateTime(2001,5,16),
    Name = "Marco Antônio Dal Vesco"
});

Console.WriteLine("---------------------");
foreach(KeyValuePair<int, Person> kvp in dicPerson){
    Console.WriteLine($"Key: {kvp.Key}");
    Console.WriteLine($"Id: {kvp.Value.Id}");
    Console.WriteLine($"Name: {kvp.Value.Name}");
    Console.WriteLine($"Birthdate: {kvp.Value.BirthDate:dd/MM/yyyy}");
    Console.WriteLine("---------------------");
}