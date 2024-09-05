using System.Collections;

//Utilizando a Lista Simples
ArrayList arrList = new();
arrList.Add(5);

arrList.Add("Kalil");
//É possível adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int[]{1, 2, 3,});
//O método .Add() insere o valor ao final do vetor
arrList.Insert(0,15);
//Insiriu o valor 15 na posição
//Já o método insert, me permite incluir o valor desejado na posição espeficada no primeiro parâmetro
//Add cria uma nova posição ao fim da lista

//Lendo valores da Lista
object first = arrList[0]!;
int fourth = (int)arrList[3]!;
//(int) força conversão para int

//Percorrendo a lista com Foreach
//Tudo é objeto
foreach(object obj in arrList){
    Console.Write($"| {obj} ");
}
Console.WriteLine("|");

//Obtendo o tamanho total da lista
int size = arrList.Count;
//Obter a capacidade 
//Quantos podem ser armazenados
int capacity = arrList.Capacity;
Console.WriteLine($"Array size is: {size}");
Console.WriteLine($"Array capacity is: {capacity}");

//Percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++){
    Console.Write($"| {arrList[i]}" );
}

//Recursos importantes das Listas
//Verificar se um valor é contido na Lista
bool containName = arrList.Contains("Kalil");
if(!containName){
    Console.WriteLine("Name Kalil not found");
}
Console.WriteLine("|");
//Para saber o índice que contem o valor buscado
//Neste caso se o valor existir na lista ele retorna o índice
//Caso o valor não exista na lista, retorna -1
int indexValue = arrList.IndexOf("Kalil");
if(indexValue >= 0){
    Console.WriteLine($"Kalil is at [{indexValue}]");
}else{
    Console.WriteLine("There is not this value");
}

//É possível também remover itens da lista
arrList.Remove("Kalil"); //Remove pelo valor
arrList.RemoveAt(4); //Remove no índice
arrList.RemoveRange(0,2); 
//O primeiro parâmetro é o índice
//E o segundo é quantas casas após o índice
//Remove 2 elementos após a posição 0 