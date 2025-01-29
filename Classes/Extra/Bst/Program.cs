using System;
using System.Linq;
using System.Text;
using BinarySearchTree;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        BinarySearchTree<int> tree = new BinarySearchTree<int>();

        tree.Root = new BinaryTreeNode<int> { Data = 100 };
        tree.Root.Left = new BinaryTreeNode<int> { Data = 50, Parent = tree.Root };
        tree.Root.Right = new BinaryTreeNode<int> { Data = 150, Parent = tree.Root };
        tree.Count = 3;
        TreeVisualizer.VisualizeTree(tree, "The BST with three nodes (50, 100, 150):");

        tree.Add(75);
        tree.Add(125);
        TreeVisualizer.VisualizeTree(tree, "The BST after adding two nodes (75, 125):");

        tree.Add(25);
        tree.Add(175);
        tree.Add(90);
        tree.Add(110);
        tree.Add(135);
        TreeVisualizer.VisualizeTree(tree, "The BST after adding five nodes (25, 175, 90, 110, 135):");

        tree.Remove(25);
        TreeVisualizer.VisualizeTree(tree, "The BST after removing the node 25:");

        tree.Remove(50);
        TreeVisualizer.VisualizeTree(tree, "The BST after removing the node 50:");

        tree.Remove(100);
        TreeVisualizer.VisualizeTree(tree, "The BST after removing the node 100:");

        Console.Write("Pre-order traversal: ");
        Console.WriteLine(string.Join(", ", tree.Traverse(BinarySearchTree<int>.TraversalEnum.PREORDER).Select(n => n.Data)));

        Console.Write("In-order traversal: ");
        Console.WriteLine(string.Join(", ", tree.Traverse(BinarySearchTree<int>.TraversalEnum.INORDER).Select(n => n.Data)));

        Console.Write("Post-order traversal: ");
        Console.WriteLine(string.Join(", ", tree.Traverse(BinarySearchTree<int>.TraversalEnum.POSTORDER).Select(n => n.Data)));
    }
}
