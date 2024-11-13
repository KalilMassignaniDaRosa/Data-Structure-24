static int ReadNumber()
{
	bool conversion = int.TryParse(Console.ReadLine(), out int number);

	while (!conversion)
	{
        Console.WriteLine("Entrada inválida! Digite um número inteiro");
		conversion = int.TryParse(Console.ReadLine(), out number);
	}
	return number;
}

Console.WriteLine("Digite 1 para digitar novos números");
Console.WriteLine("Digite 2 para ordenar os números já cadastrados");


int option = ReadNumber();

List<int> arr = [12, 43, 23, 423, 11, 214];

bool loop = true;

while (loop)
{
	switch (option)
	{
		case 1:
			
			Console.WriteLine("Digite -1 para parar");
			int number;
			do
			{
				number = ReadNumber();

				if (number == -1)
					break;

				arr.Add(number);
			
			} while (number != -1);
			loop = false;
			break;
		case 2:
			loop = false;
			break;
		default:
			Console.WriteLine("Entrada inválida, digite outro número");
			option = ReadNumber();
			break;
	}
}

ShellSort.ShellSort.Sort(arr);
Console.WriteLine();

foreach (var item in arr)
    Console.Write($"{item} ");
