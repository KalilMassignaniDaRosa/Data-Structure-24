using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSort
    {
        // Versao publica do metodo Sort que so recebe o array
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        // Versao privada que recebe os indices lower e upper para a recursao
        private static void Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);  // Obtem a posicao do pivo
                Sort(array, lower, p);                   // Ordena a sublista a esquerda do pivot
                Sort(array, p + 1, upper);               // Ordena a sublista a direita do pivot
            }
        }

        public static int Partition<T>(
            T[] array,
            int lower,
            int upper,
            bool showAll = false
        // Para mostrar o pivot mudar para true
        ) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            do
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    if (showAll)
                    {
                        Console.WriteLine($"Pivot: {pivot} | Array: {array[i]}");
                        Thread.Sleep(100);
                    }
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    if (showAll)
                    {
                        Console.WriteLine($"Pivot: {pivot} | Array: {array[j]}");
                        Thread.Sleep(100);
                    }
                    j--;
                }
                if (i >= j) { break; }
                Swap(array, i, j);
            }
            while (i <= j);

            return j;
        }

        public static void Swap<T>(
            T[] array,
            int first,
            int second
        )
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (T a in array)
            {
                Thread.Sleep(100);
                Console.Write($"{a} ");
            }

            Console.Write("]");
            Console.WriteLine("");
        }
    }
}