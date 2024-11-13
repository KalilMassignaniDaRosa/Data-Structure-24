namespace ShellSort
{
	public class ShellSort
	{
		public static void Sort<T>(List<T> array) where T : IComparable
		{
			int n = array.Count;

			for (int gap = n / 2; gap > 0; gap /= 2)
			{
				for (int i = gap; i < n; i++)
				{
					T temp = array[i];
					int j;
					bool houveTroca = false; 
					bool houveComparacaoSemTroca = false; 
					
					for (j = i; j >= gap; j -= gap)
					{
						if (array[j - gap].CompareTo(temp) > 0)
						{
							array[j] = array[j - gap];
							houveTroca = true; 
						}
						else
						{
							houveComparacaoSemTroca = true;
							break;
						}
					}
					
					array[j] = temp;
					
					for (int k = 0; k < array.Count; k++)
					{
						if (houveTroca && (k == j || k == i))
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write($"{array[k]} ");
							Console.ResetColor();
						}
						else if (!houveTroca && houveComparacaoSemTroca && (k == j || k == j - gap)) 
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

					Console.WriteLine();
					Thread.Sleep(100); 
				}
			}
		}
	}
}