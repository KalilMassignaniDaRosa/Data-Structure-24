using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static int Delay { get; set; } = 100; 

        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;

                while(j > 0 && array[j].CompareTo(array[j -1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        // Como = false e o padrao caso nao seja especificado
        public static void Swap<T>(T[] array, int first, int second, bool showAll = false){
            if (showAll) InsertionSort.Print(array);
            T temp = array[first];

            array[first] = array[second];
            if (showAll) InsertionSort.Print(array);

            array[second] = temp;
            if (showAll) InsertionSort.Print(array);
        }

        public static void Print<T>(T[] array){
            Console.Write("[ ");
            foreach (T a in array){
                Thread.Sleep(Delay);
                Console.Write($"{a} ");
            }
            Console.Write("]\n");
        }
    }
}