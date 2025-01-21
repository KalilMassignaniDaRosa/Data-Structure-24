using System;
using RadixSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
RadixSort.RadixSort.Print(values);
int[] sortedData = RadixSort.RadixSort.Sort(values);

Console.WriteLine("Sorted with Radix: ");
RadixSort.RadixSort.Print(values);