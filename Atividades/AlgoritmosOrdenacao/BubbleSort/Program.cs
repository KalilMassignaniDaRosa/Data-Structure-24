using BubbleSort;

int[] ints = [0, 12, 7, 1, 2, 8];

BubbleSort.BubbleSort.Print(ints, 100);
Console.WriteLine("Sorted with Bubble: ");

BubbleSort.BubbleSort.Sort<int>(ints);
BubbleSort.BubbleSort.Print(ints, 100);

Console.WriteLine("Char Test");
char[] chars = ['x', 'z', 'b', 'c', 'a'];

BubbleSort.BubbleSort.Print(chars, 100);

BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars, 100);