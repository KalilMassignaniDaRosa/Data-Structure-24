using System.Security.Principal;
using HeapSort;

int min = 0;
int max = 100;

Random aleArray = new Random();
int tamarray = aleArray.Next(1, 10);

int[] numeros = new int[tamarray];

Random aleatorio = new Random();
for (int i = 0; i < numeros.Length; i++){
    numeros[i] = aleatorio.Next(min, max);
}


HeapSort.HeapSort.Print(numeros);
HeapSort.HeapSort.SortArray<int>(numeros, numeros.Length);
HeapSort.HeapSort.Print(numeros);