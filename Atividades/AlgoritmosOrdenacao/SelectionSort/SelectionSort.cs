using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                Swap(array, i, minIndex);
            }
            return array;
        }

        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array)
        {
            Console.Write("[");
            foreach (T i in array)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");
        }
    }
}
