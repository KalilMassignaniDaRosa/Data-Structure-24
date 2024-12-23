using System.Runtime.InteropServices;
using MergeSort;

int[] values = {9, 2, 5, 10, 1, 7, 3, 8, 6, 4};

Console.WriteLine("Array: ");
MergeSort.MergeSort.Print(values);

Console.WriteLine("Sorted with Merge: ");
int[] ordened = MergeSort.MergeSort.Sort(values);
MergeSort.MergeSort.Print(ordened);