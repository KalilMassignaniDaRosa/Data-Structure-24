using System;
using System.Collections.Generic;
using System.Threading;

namespace ShellSort
{
	public class ShellSort
	{
		public static void Sort<T>(List<T> array) where T : IComparable
		{
			int size = array.Count;

			for (int gap = size / 2; gap > 0; gap /= 2)
			{
				for (int i = gap; i < size; i++)
				{
					PerformInsertionSort(array, gap, i);
				}
			}
		}

		private static void PerformInsertionSort<T>(
			List<T> array, int gap, 
			int i, bool showAll = false // Se for true mostra o passo a passo
			) where T : IComparable
		{
			T temp = array[i];
			int j = i;
			bool hasSwap = false;
			bool hasComparisonWithoutSwap = false;

			j = ShiftElements(array, gap, temp, ref hasSwap, ref hasComparisonWithoutSwap, j);

			array[j] = temp;

			// Exibe o estado do array somente se showAll for true
			if (showAll)
			{
				DisplayArrayState(array, gap, i, j, hasSwap, hasComparisonWithoutSwap);
			}
		}


		private static int ShiftElements<T>(
			List<T> array, 
			int gap, 
			T temp, 
			ref bool hasSwap, // Ref passa por referencia, e um modificador de parametro
			ref bool hasComparisonWithoutSwap, 
			int j
		) where T : IComparable
		{
			while (j >= gap)
			{
				if (array[j - gap].CompareTo(temp) > 0)
				{
					array[j] = array[j - gap];
					hasSwap = true;
				}
				else
				{
					hasComparisonWithoutSwap = true;
					break;
				}
				j -= gap;
			}

			return j;
		}

		private static void DisplayArrayState<T>(
			List<T> array, 
			int gap, 
			int i, 
			int j, 
			bool hasSwap, 
			bool hasComparisonWithoutSwap
		) where T : IComparable
		{
			Console.Write("[ ");
			for (int k = 0; k < array.Count; k++)
			{
				if (hasSwap && (k == j || k == i))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write($"{array[k]} ");
					Console.ResetColor();
				}
				else if (!hasSwap && hasComparisonWithoutSwap && (k == j || k == j - gap))
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write($"{array[k]} ");
					Console.ResetColor();
				}
				else
				{
					Console.Write($"{array[k]} ");
				}
			}

			Console.WriteLine("]");
			Thread.Sleep(100);
		}

		public static void Print<T>(List<T> array)
		{
			Console.Write("[ ");
			foreach (T a in array)
			{
				Thread.Sleep(100);
				Console.Write($"{a} ");
			}
			Console.Write("]");
			Console.WriteLine("");
		}
	}
}
