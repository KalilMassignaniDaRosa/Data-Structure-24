using RbTree;

RedBlackTreeList<int> tree = new RedBlackTreeList<int>();

for (int i = 1; i <= 10; i++)
{
    tree.Add(i);
}

tree.Remove(9);

bool contains = tree.Contains(5);
Console.WriteLine("Does value exist? " + (contains ? "Yes" : "No"));

// Obtendo a quantidade de elementos e o intervalo
uint count = tree.Count;
tree.Greatest(out int greatest);
tree.Least(out int least);
Console.WriteLine($"{count} elements in the range {least}-{greatest}");

// Usando string.Join
Console.WriteLine("Values: " + string.Join(", ", tree.ToList())); // Converte para lista para usar string.Join

// Outra forma de imprimir
Console.Write("Values: ");
foreach (var node in tree)
{
    Console.Write(node + " ");
}