using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvlTree
{
    public static class AvlTreeVisualizer<T> where T : IComparable<T>
    {
        private const int COLUMN_WIDTH = 5;
        // Por conflitos usando T na classe
        // E TNode nos metodos

        public static void VisualizeTree<TNode>(AvlTree<T> tree, string caption) where TNode : IComparable<T>
        {
            if (tree == null) return;

            Node<T>? root = tree.GetRoot();
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            char[][] console = InitializeVisualization(root, out int width);
            VisualizeNode(root, 0, width / 2, console, width);

            Console.WriteLine(caption);
            foreach (char[] row in console)
            {
                Console.WriteLine(new string(row));
            }
        }

        private static char[][] InitializeVisualization<TNode>(Node<TNode> root, out int width) where TNode : IComparable<T>
        {
            int height = GetHeight(root);
            width = (int)Math.Pow(2, height) - 1;
            char[][] console = new char[height * 2][];

            for (int i = 0; i < height * 2; i++)
            {
                console[i] = new string(' ', COLUMN_WIDTH * width).ToCharArray();
            }
            return console;
        }

        private static int GetHeight<TNode>(Node<TNode> node) where TNode : IComparable<T>
        {
            if (node == null) return 0;
            return Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }

        private static void VisualizeNode<TNode>(Node<TNode> node, int row, int column, char[][] console, int width) where TNode : IComparable<T>
        {
            if (node == null) return;

            // Convertendo o valor do no para caracteres
            string nodeValue = node.Data!.ToString()!;
            char[] chars = nodeValue.ToCharArray();

            // Centralizando os caracteres dentro da coluna
            int margin = (COLUMN_WIDTH - chars.Length) / 2;

            for (int i = 0; i < chars.Length; i++)
            {
                console[row][COLUMN_WIDTH * column + i + margin] = chars[i];
            }

            // Calculando deslocamento para a proxima linha
            int columnDelta = Math.Max(1, width / (int)Math.Pow(2, row + 2));

            // Desenhando os filhos e suas conexoes
            if (node.Left != null)
            {
                VisualizeNode(node.Left, row + 2, column - columnDelta, console, width);
                DrawLineLeft(node, row, column, console, columnDelta);
            }

            if (node.Right != null)
            {
                VisualizeNode(node.Right, row + 2, column + columnDelta, console, width);
                DrawLineRight(node, row, column, console, columnDelta);
            }
        }


        private static void DrawLineLeft<TNode>(Node<TNode> node, int row, int column, char[][] console, int columnDelta) where TNode : IComparable<T>
        {
            if (node.Left != null)
            {
                int startColumnIndex = COLUMN_WIDTH * (column - columnDelta) + 2;
                int endColumnIndex = COLUMN_WIDTH * column + 2;

                for (int x = startColumnIndex + 1; x < endColumnIndex; x++)
                {
                    console[row + 1][x] = '\u2500'; // ─
                }

                console[row + 1][startColumnIndex] = '\u250c'; // ┌
                console[row + 1][endColumnIndex] = '\u2534'; // ┴
            }
        }

        private static void DrawLineRight<TNode>(Node<TNode> node, int row, int column, char[][] console, int columnDelta) where TNode : IComparable<T>
        {
            if (node.Right != null)
            {
                int startColumnIndex = COLUMN_WIDTH * column + 2;
                int endColumnIndex = COLUMN_WIDTH * (column + columnDelta) + 2;

                for (int x = startColumnIndex + 1; x < endColumnIndex; x++)
                {
                    console[row + 1][x] = '\u2500'; // ─
                }

                console[row + 1][startColumnIndex] = '\u2534'; // ┴
                console[row + 1][endColumnIndex] = '\u2510'; // ┐
            }
        }
    }
}
