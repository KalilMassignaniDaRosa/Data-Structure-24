using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogoSort
{
    public class BogoSort
    {
        static Random random = new Random();

        public static void Sort<T>(T[] array, bool showAll = false) where T : IComparable
        {
            while (!IsSorted(array))
            {
                // Embaralhar
                Shuffle(array, showAll);
            }
        }

        static bool IsSorted<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Shuffle<T>(T[] array, bool showAll = false) where T : IComparable
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length);

                //Console.WriteLine($"Change: {array[i]} with {array[j]}");
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                
                if(showAll){
                    Console.WriteLine("Array after change: ");
                    Print(array, 0);
                }
            }
        }

        public static void Print<T>(T[] array, int delay=100)
        {
            Console.Write("[ ");
            foreach (T a in array)
            {
                Thread.Sleep(delay);
                Console.Write($"{a} ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}