using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CombSort
{
    public class CombSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            int length = array.Length;
            int gap = length; // Inicialmente o gap é o tamanho do array
            bool swapped = true;

            while (gap != 1 || swapped)
            {
                // Atualiza o gap utilizando a constante de encolhimento padrão (1.3)
                gap = (gap * 10) / 13;
                if (gap < 1)
                    gap = 1;

                swapped = false;

                for (int i = 0; i < length - gap; i++)
                {
                    // Comparando os elementos utilizando IComparable<T>
                    if (array[i].CompareTo(array[i + gap]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;
                    }
                }
            }

            return array;
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