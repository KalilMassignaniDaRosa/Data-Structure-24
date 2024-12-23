// <> significa generico
using System.ComponentModel.Design.Serialization;
using ListaGenerica;

List<double> numbers = new List<double>();

do{
    Console.WriteLine("Insert a number: ");
    string? numberStr = Console.ReadLine();
    //Validando a entrada do usuario
    //out faz sair uma variavel
    //out eh uma referencia
    if(!double.TryParse(numberStr, out double number)){
        break;
    }
    numbers.Add(number);
    Console.WriteLine($"The average of numbers are {numbers.Average()}");
}while(true);

// Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;

people.Add(p1);

p1.Name = "Joaquim José da Silva Xavier";
people.Add(new Person(){
    Name= "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

Person p3 = new Person(){
    Name = "Arnold e SuasNega",
    Age = 65,
    Country = CountryEnum.JP
};
people.Add(p3);

//Formas de percorrer a Lista Generica
foreach(Person p in people){
    Console.WriteLine($"Name: {p.Name}");
}

//Modo for tradicional
for (int i = 0; i < people.Count; i++){
    Console.WriteLine($"Name: {people[i].Name}");
}