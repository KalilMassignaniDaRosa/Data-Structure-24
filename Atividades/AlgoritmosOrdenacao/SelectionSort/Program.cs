using SelectionSort;

Console.WriteLine("Numbers:");
int[] values = { 0, 6, 45, 18, 115, 13 };
SelectionSort.SelectionSort.Print(values);

Console.WriteLine();

Console.WriteLine("In order:");
SelectionSort.SelectionSort.Sort<int>(values);
SelectionSort.SelectionSort.Print(values);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Names:");
string[] names = { "Storm", "Nightcrawler", "Gambit", "Magneto" }; 
SelectionSort.SelectionSort.Print(names);

Console.WriteLine();

Console.WriteLine("In order:");
SelectionSort.SelectionSort.Sort(names); 
SelectionSort.SelectionSort.Print(names);