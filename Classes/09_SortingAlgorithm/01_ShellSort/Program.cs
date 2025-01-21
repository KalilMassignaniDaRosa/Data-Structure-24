using ShellSort;

List<int> values = new List<int> { 9, 2, 5, 10, 1, 7, 3, 8, 6, 4 };

Console.WriteLine("Array: ");
ShellSort.ShellSort.Print(values);
ShellSort.ShellSort.Sort(values);

Console.WriteLine("Sorted with Shell: ");
ShellSort.ShellSort.Print(values);