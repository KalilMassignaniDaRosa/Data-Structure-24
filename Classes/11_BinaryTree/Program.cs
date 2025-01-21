using BinaryTree;

// Criando a arvore
BinaryTree<int> tree = new BinaryTree<int>();

// Criando os nos
BinaryTreeNode<int> root = new BinaryTreeNode<int> { Data = 1, Children = new List<TreeNode<int>> { null!, null! } };
BinaryTreeNode<int> node2 = new BinaryTreeNode<int> { Data = 2, Children = new List<TreeNode<int>> { null!, null! } };
BinaryTreeNode<int> node3 = new BinaryTreeNode<int> { Data = 3, Children = new List<TreeNode<int>> { null!, null! } };
BinaryTreeNode<int> node4 = new BinaryTreeNode<int> { Data = 4, Children = new List<TreeNode<int>> { null!, null! } };
BinaryTreeNode<int> node5 = new BinaryTreeNode<int> { Data = 5, Children = new List<TreeNode<int>> { null!, null! } };

// Montando a arvore
tree.Root = root;
root.Left = node2;
root.Right = node3;
node2.Left = node4;
node2.Right = node5;

Console.WriteLine("PreOrder:");
Console.Write("[ ");
foreach (var node in tree.Traverse(BinaryTree<int>.TraversalEnum.PREORDER))
{
    Console.Write(node.Data + " ");
}
Console.WriteLine("]");

Console.WriteLine("InOrder:");
Console.Write("[ ");
foreach (var node in tree.Traverse(BinaryTree<int>.TraversalEnum.INORDER))
{
    Console.Write(node.Data + " ");
}
Console.WriteLine("]");

Console.WriteLine("PostOrder:");
Console.Write("[ ");
foreach (var node in tree.Traverse(BinaryTree<int>.TraversalEnum.POSTORDER))
{
    Console.Write(node.Data + " ");
}
Console.WriteLine("]");

Console.WriteLine("Tree Height: " + tree.GetTreeHeight());