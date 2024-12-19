using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimSort
{
    public class TimSort
    {
        private const int RUN = 32;

        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;

            // Separando pequenos blocos usando o insertion Sort
            for (int i = 0; i < n; i += RUN)
            {
                InsertionSort(array, i, Math.Min((i + RUN - 1), (n - 1)));
            }

            // Merge Sort ordenado
            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (n - 1));

                    if (mid < right)
                    {
                        Merge(array, left, mid, right);
                    }
                }
            }
        }

        private static void InsertionSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            for (int i = left + 1; i <= right; i++)
            {
                T temp = array[i];
                int j = i - 1;

                while (j >= left && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp;
            }
        }

        private static void Merge<T>(T[] array, int left, int mid, int right) where T : IComparable<T>
        {
            int len1 = mid - left + 1;
            int len2 = right - mid;

            T[] leftArray = new T[len1];
            T[] rightArray = new T[len2];

            for (int x = 0; x < len1; x++)
            {
                leftArray[x] = array[left + x];
            }
            for (int x = 0; x < len2; x++)
            {
                rightArray[x] = array[mid + 1 + x];
            }

            int i = 0, j = 0, k = left;

            while (i < len1 && j < len2)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }

            while (i < len1)
            {
                array[k++] = leftArray[i++];
            }

            while (j < len2)
            {
                array[k++] = rightArray[j++];
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