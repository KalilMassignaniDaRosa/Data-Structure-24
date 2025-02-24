using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvlTree
{
    public class AvlTree<T> where T : IComparable<T>
    {
        private Node<T>? root;

        private int GetHeight(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            return node.Height;
        }

        public Node<T>? GetRoot()
        {
            return root;
        }

        // Fator de balanceamento = esquerda - direita
        private int GetBalanceFactor(Node<T> node)
        {
            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return leftHeight - rightHeight;
        }

        private Node<T> RotateRight(Node<T> y)
        {
            Node<T> x = y.Left;
            Node<T> T2 = x.Right;

            // Realiza rotacao
            x.Right = y;
            y.Left = T2;

            // Atualiza as alturas
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        private Node<T> RotateLeft(Node<T> x)
        {
            Node<T> y = x.Right;
            Node<T> T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y;
        }

        private Node<T> Insert(Node<T> node, T data)
        {
            if (node == null)
                return new Node<T>(data);

            if (data.CompareTo(node.Data) < 0)
                node.Left = Insert(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = Insert(node.Right, data);
            else
                return node;

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalanceFactor(node);

            // Caso Left-Left (LL): Subarvore esquerda desbalanceada
            if (balance > 1 && data.CompareTo(node.Left.Data) < 0)
                return RotateRight(node);

            // Caso Right-Right (RR): Subarvore direita desbalanceada
            if (balance < -1 && data.CompareTo(node.Right.Data) > 0)
                return RotateLeft(node);

            // Caso Left-Right (LR): A subarvore esquerda tem um no a direita desbalanceado
            if (balance > 1 && data.CompareTo(node.Left.Data) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Caso Right-Left (RL): A subarvore direita tem um no a esquerda desbalanceado
            if (balance < -1 && data.CompareTo(node.Right.Data) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        public void Add(T data) => root = Insert(root!, data);

        public IEnumerable<T> GetInorderEnumerator()
        {
            var list = new List<T>();
            InOrder(root!, list);
            return list;
        }

        private void InOrder(Node<T> node, List<T> list)
        {
            if (node == null) return;
            InOrder(node.Left, list);
            list.Add(node.Data!);
            InOrder(node.Right, list);
        }

        public IEnumerable<T> GetPostorderEnumerator()
        {
            var list = new List<T>();
            PostOrder(root!, list);
            return list;
        }

        private void PostOrder(Node<T> node, List<T> list)
        {
            if (node == null) return;
            PostOrder(node.Left, list);
            PostOrder(node.Right, list);
            list.Add(node.Data!);
        }

        public IEnumerable<T> GetBreadthFirstEnumerator()
        {
            var list = new List<T>();
            if (root == null) return list;

            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                list.Add(node.Data!);

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            return list;
        }
    }
}