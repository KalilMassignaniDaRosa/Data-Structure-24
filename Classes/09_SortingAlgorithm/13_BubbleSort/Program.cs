using BubbleSort;

int[] values = [9, 2, 5, 10, 1, 7, 3, 8, 6, 4];
Console.WriteLine("Array:");
BubbleSort.BubbleSort.Print(values);

Console.WriteLine("Sorted with Bubble: ");
BubbleSort.BubbleSort.Sort(values);
BubbleSort.BubbleSort.Print(values);