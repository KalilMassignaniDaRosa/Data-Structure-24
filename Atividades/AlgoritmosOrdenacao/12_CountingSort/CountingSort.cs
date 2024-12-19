using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingSort
{
    public class CountingSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length == 0)
                return;

            int max = array[0];
            int min = array[0];
            foreach (var num in array)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            // Cria um array de contagem para armazenar a frequencia de cada elemento
            int range = max - min + 1;
            int[] count = new int[range];

            // Preencher o array de contagem
            foreach (var num in array)
            {
                count[num - min]++;
            }

            // Sobrescrever o array original com os valores ordenados
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (count[i] > 0)
                {
                    array[index++] = i + min;
                    count[i]--;
                }
            }
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