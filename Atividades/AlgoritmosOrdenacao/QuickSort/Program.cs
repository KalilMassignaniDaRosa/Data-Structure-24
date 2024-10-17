using QuickSort;

int[] values = [0, 12, 7, 1, 2, 8];

Console.WriteLine("Array: ");
QuickSort.QuickSort.Print<int>(values);

QuickSort.QuickSort.Sort<int>(values, 0, values.Length-1);

Console.WriteLine("Sorted with Quick: ");
QuickSort.QuickSort.Print(values);