using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomeSort
{
    public static class GnomeSort
    {
        public static void Sort(int[] array)
        {
            int i = 1; // Começa do segundo elemento
            while (i < array.Length)
            {
                // Se o elemento atual é maior ou igual ao anterior, move para o próximo
                if (i == 0 || array[i] >= array[i - 1])
                {
                    i++;
                }
                else
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i--; 
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