using System.Collections;

// Utilizando a Lista Simples
ArrayList arrList = new();
arrList.Add(5);

arrList.Add("Kalil");
// E possivel adicionar um conjunto de valores de uma so vez
arrList.AddRange(new int[]{1, 2, 3,});
// O metodo .Add() insere o valor ao final do vetor
arrList.Insert(0,15);
// Insiriu o valor 15 na posicao
// Ja o metodo insert, me permite incluir o valor desejado na posicao espeficada no primeiro parametro
// Add cria uma nova posicao ao fim da lista

// Lendo valores da Lista
object first = arrList[0]!;
int fourth = (int)arrList[3]!;
// (int) forca conversao para int

// Percorrendo a lista com Foreach
// Tudo e objeto
foreach(object obj in arrList){
    Console.Write($"| {obj} ");
}
Console.WriteLine(" |");

// Obtendo o tamanho total da lista
int size = arrList.Count;
// Obter a capacidade 
// Quantos podem ser armazenados
int capacity = arrList.Capacity;
Console.WriteLine($"Array size is: {size}");
Console.WriteLine($"Array capacity is: {capacity}");

// Percorrendo no modo classico
for(int i = 0; i < arrList.Count; i++){
    Console.Write($"| {arrList[i]} " );
}

// Recursos importantes das Listas
// Verificar se um valor e contido na Lista
bool containName = arrList.Contains("Kalil");
if(!containName){
    Console.WriteLine("Name Kalil not found");
}
Console.WriteLine(" |");
// Para saber o indice que contem o valor buscado
// Neste caso se o valor existir na lista ele retorna o indice
// Caso o valor nao exista na lista, retorna -1
int indexValue = arrList.IndexOf("Kalil");
if(indexValue >= 0){
    Console.WriteLine($"Kalil is at [{indexValue}]");
}else{
    Console.WriteLine("There is not this value");
}

// E possível tambem remover itens da lista
arrList.Remove("Kalil"); // Remove pelo valor
arrList.RemoveAt(4); // Remove no indice
arrList.RemoveRange(0,2); 
// O primeiro parametro e o indice
// E o segundo e quantas casas apos o indice
// Remove 2 elementos apos a posicao 0 