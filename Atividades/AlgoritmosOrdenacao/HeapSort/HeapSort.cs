using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeapSort
{
    public class HeapSort
    {
        public static T[] SortArray<T>(T[] array, int size)where T : IComparable{

            if (size <= 1){
                return array;
            }
            for (int i = size / 2 - 1; i >= 0; i--){ // pega o item pai da arvore
                Heapify(array, size, i);
            }
            for (int i = size - 1; i >= 0; i--){
                T tempVar = array[0];
                array[0] = array[i];
                array[i] = tempVar;
                Heapify(array, i, 0);
            }
            return array;
        }
    

        public static void Heapify<T>(T[] array, int size, int index)where T : IComparable{
            int largestIndex = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            if (leftChild < size && array[leftChild].CompareTo(array[largestIndex]) > 0)
            {
                largestIndex = leftChild;
            }
            if (rightChild < size && array[rightChild].CompareTo(array[largestIndex]) > 0)
            {
                largestIndex = rightChild;
            }
            if (largestIndex != index)
            {
                var tempVar = array[index];
                array[index] = array[largestIndex];
                array[largestIndex] = tempVar;
                Heapify(array, size, largestIndex);
            }
        }
        public static void Print<T>(T[] array){
            Console.Write("[");
            foreach(T i in array){
                Console.Write($"{i} ");
            }
            Console.Write("]\n");
        }
        
       
    }
}
