using System;
using GnomeSort;

int[] values = { 9, 2, 5, 10, 1, 7, 3, 8, 6, 4 };

Console.WriteLine("Array:");
GnomeSort.GnomeSort.Print(values);
GnomeSort.GnomeSort.Sort(values);

Console.WriteLine("Sorted with Gnome:");
GnomeSort.GnomeSort.Print(values);