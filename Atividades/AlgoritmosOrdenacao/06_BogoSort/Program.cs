//int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];
int[] values = [3, 1, 2, 5, 4];

Console.WriteLine("Array: ");
BogoSort.BogoSort.Print(values);
BogoSort.BogoSort.Sort(values);

Console.WriteLine("Sorted with Bogo: ");
BogoSort.BogoSort.Print(values);