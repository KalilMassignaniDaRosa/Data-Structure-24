using System;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
TimSort.TimSort.Print(values);
TimSort.TimSort.Sort(values);

Console.WriteLine("Sorted with Tim: ");
TimSort.TimSort.Print(values);