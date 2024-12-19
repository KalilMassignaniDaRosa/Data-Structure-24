using OddEvenSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
OddEvenSort.OddEvenSort.Print(values);
OddEvenSort.OddEvenSort.Sort(values);

Console.WriteLine("Sorted with Odd-Even: ");
OddEvenSort.OddEvenSort.Print(values);