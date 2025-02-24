using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvlTree;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AvlTree<int> tree = new AvlTree<int>();

        tree.Add(100);
        tree.Add(50);
        tree.Add(150);
        AvlTreeVisualizer<int>.VisualizeTree<int>(tree, "The AVL Tree with three nodes (50, 100, 150):");

        tree.Add(75);
        tree.Add(25);
        AvlTreeVisualizer<int>.VisualizeTree<int>(tree, "The AVL Tree after adding two nodes (75, 25):");

        tree.Add(125);
        tree.Add(175);
        tree.Add(90);
        tree.Add(110);
        tree.Add(135);
        AvlTreeVisualizer<int>.VisualizeTree<int>(tree, "The AVL Tree after adding five nodes (125, 175, 90, 110, 135):");

        Console.WriteLine("========================================================================");
        Console.Write("Breadth-first traversal: ");
        Console.WriteLine(string.Join(", ", tree.GetBreadthFirstEnumerator()));

        Console.Write("In-order traversal: ");
        Console.WriteLine(string.Join(", ", tree.GetInorderEnumerator()));

        Console.Write("Post-order traversal: ");
        Console.WriteLine(string.Join(", ", tree.GetPostorderEnumerator()));
    }
}
