using System;

class Compras
{
    static void Main()
    {
        string[] comprasArray = { "Frango", "Bife", "Maçã", "Banana", "Peixe", "Pera", "Tomate", "Laranja" };

        // Simulando um Merge Sort, separando a array em 2 subarrays de tamanho = 4
        string[] run1 = new string[4];
        string[] run2 = new string[4];

        Array.Copy(comprasArray, 0, run1, 0, 4);
        Array.Copy(comprasArray, 4, run2, 0, 4);

        // Ordena as subarrays usando um Insertion Sort
        Array.Sort(run1);
        Array.Sort(run2);

        // Junta as duas subarrays
        string[] novaArray = new string[run1.Length + run2.Length];
        Array.Copy(run1, 0, novaArray, 0, run2.Length);
        Array.Copy(run2, 0, novaArray, run1.Length, run2.Length);

        // Ordena a array que foi juntada
        Array.Sort(novaArray);

        // Resultado
        Console.WriteLine("Itens do Mercado: {0}", string.Join(", ", comprasArray));
        Console.WriteLine("1ª Array ordenada: {0}", string.Join(", ", run1));
        Console.WriteLine("2º Array ordenada: {0}", string.Join(", ", run2));
        Console.WriteLine("Array combinada e ordenada: {0}", string.Join(", ", novaArray));
    }
}