int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
CountingSort.CountingSort.Print(values);
CountingSort.CountingSort.Sort(values);

Console.WriteLine("Sorted with Counting: ");
CountingSort.CountingSort.Print(values);