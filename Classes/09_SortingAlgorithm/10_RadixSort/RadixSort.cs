using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadixSort
{
    public class RadixSort
    {
        public static int[] Sort(int[] data)
        {
            int max = GetMax(data);

            // Passa pelos digitos um por um, comecando do menos significativo
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                data = CountSortByDigit(data, exp);
            }

            return data;
        }

        // Funcao para encontrar o valor maximo no array
        private static int GetMax(int[] data)
        {
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
            }
            return max;
        }

        // Funcao de ordenacao que organiza os numeros com base no digito especifico
        private static int[] CountSortByDigit(int[] data, int exp)
        {
            int[] output = new int[data.Length]; // Array de saida
            int[] count = new int[10]; // Armazena contagem dos digitos (0-9)

            // Inicializa o array de contagem
            for (int i = 0; i < data.Length; i++)
            {
                int digit = (data[i] / exp) % 10;
                count[digit]++;
            }

            // Modifica count[] para ter a posicao correta de cada digito
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Constroi o array de saida
            for (int i = data.Length - 1; i >= 0; i--)
            {
                int digit = (data[i] / exp) % 10;
                output[count[digit] - 1] = data[i];
                count[digit]--;
            }

            return output;
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