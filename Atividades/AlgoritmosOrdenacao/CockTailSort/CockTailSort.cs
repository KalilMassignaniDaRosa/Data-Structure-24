using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CockTailSort
{
    public class CockTailSort
    {
<<<<<<< HEAD
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            bool swapped = true;
            int lower = 0;
            int upper = array.Length - 1;

            while (swapped)
            {
                swapped = false;

                //Parecido com o Bubble
                for (int i = lower; i < upper; i++)
                {
                    //Compara atual com o proximo
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        //Se o elemento atual e maior troca
                        Swap(array, i, i+1);
                        swapped = true;
                    }
                }

                //Se nenhuma troca foi feita, ja esta ordenado
                if (!swapped)
                    break;
            
                swapped = false;
                //Reduz limite superior
                upper--;

                for (int i = upper; i > lower; i--)
                {
                    //Compara atual com o anterior
                    if (array[i].CompareTo(array[i - 1]) < 0)
                    {
                        //Se o elemento atual e menor troca
                        Swap(array, i, i-1);
                        swapped = true;
                    }
                }
                //Aumenta o limite inferior
                lower++;
            }
            return array;
        }   
    

        public static void Swap<T>(
            T[] array,
            int first,
=======
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
>>>>>>> d3fae094c5d43913fef429f76c4bd8eeeea6ce14
            int second
        )
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

<<<<<<< HEAD
        public static void Print<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (T a in array)
            {
=======
        public static void Print<T>(T[] array){
            Console.Write("[ ");
            foreach (T a in array){
>>>>>>> d3fae094c5d43913fef429f76c4bd8eeeea6ce14
                Thread.Sleep(100);
                Console.Write($"{a} ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}