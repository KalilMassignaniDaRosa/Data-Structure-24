using CockTailSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];

Console.WriteLine("Array: ");
CockTailSort.CockTailSort.Print(values);
CockTailSort.CockTailSort.Sort(values);

Console.WriteLine("Sorted with Cocktail: ");
CockTailSort.CockTailSort.Print(values);