using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OddEvenSort
{
    public static class OddEvenSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            bool isSorted = false;
            int n = array.Length;

            while (!isSorted)
            {
                isSorted = true;

                // Odd-indexed pass
                for (int i = 1; i < n - 1; i += 2)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swap(array, i, i + 1);
                        isSorted = false;
                    }
                }

                // Even-indexed pass
                for (int i = 0; i < n - 1; i += 2)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swap(array, i, i + 1);
                        isSorted = false;
                    }
                }
            }
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