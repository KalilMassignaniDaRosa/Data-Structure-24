using SelectionSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
SelectionSort.SelectionSort.Print(values);
SelectionSort.SelectionSort.Sort(values);

Console.WriteLine("Sorted with Selection: ");
SelectionSort.SelectionSort.Print(values);