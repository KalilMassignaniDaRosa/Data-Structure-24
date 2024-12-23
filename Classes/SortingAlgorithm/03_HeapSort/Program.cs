using System.Security.Principal;
using HeapSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
HeapSort.HeapSort.Print(values);

Console.WriteLine("Sorted with Heap: ");
HeapSort.HeapSort.Sort(values);
HeapSort.HeapSort.Print(values);