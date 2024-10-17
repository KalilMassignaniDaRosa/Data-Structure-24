using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CockTailSort
{
    public class CockTailSort
    {
        public static T[] Sort<T>(
            T[] array, 
            int lower, 
            int upper
        ) where T : IComparable
        {
            bool swapped = false;
            
            return array;
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

        public static void Print<T>(T[] array){
            Console.Write("[ ");
            foreach (T a in array){
                Thread.Sleep(100);
                Console.Write($"{a} ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}