using InsertionSort;

int[] ints = [0, 12, 7, 1, 2, 8];

InsertionSort.InsertionSort.Print(ints, 100);
Console.WriteLine("Sorted with Insertion: ");

InsertionSort.InsertionSort.Sort<int>(ints);
InsertionSort.InsertionSort.Print(ints, 100);

Console.WriteLine("Char Test");
char[] chars = ['x', 'z', 'b', 'c', 'a'];

InsertionSort.InsertionSort.Print(chars, 100);

InsertionSort.InsertionSort.Sort(chars);
InsertionSort.InsertionSort.Print(chars, 100);