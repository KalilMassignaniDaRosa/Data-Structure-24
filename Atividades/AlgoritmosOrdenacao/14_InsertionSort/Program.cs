using InsertionSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
InsertionSort.InsertionSort.Print(values);

Console.WriteLine("Sorted with Insertion: ");
InsertionSort.InsertionSort.Sort(values);
InsertionSort.InsertionSort.Print(values);