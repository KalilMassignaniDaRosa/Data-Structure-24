using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        // Verifica se a arvore contem um valor
        public bool Contains(T data)
        {
            BinaryTreeNode<T> node = Root!;

            while (node != null)
            {
                int result = data.CompareTo(node.Data);
                if (result == 0)
                {
                    return true;
                }
                else if (result < 0)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }
            return false;
        }

        // Metodo Insertion
        public void Add(T data)
        {
            BinaryTreeNode<T> parent = GetParentForNewNode(data);
            BinaryTreeNode<T> node = new BinaryTreeNode<T>()
            {
                Data = data,
                Parent = parent
            };

            if (parent == null)
            {
                Root = node;
            }
            else if (data.CompareTo(parent.Data) < 0)
            {
                parent.Left = node;
            }
            else
            {
                parent.Right = node;
            }
            Count++;
        }

        // Metodo auxiliar para achar o elemento pai
        private BinaryTreeNode<T> GetParentForNewNode(T data)
        {
            BinaryTreeNode<T> current = Root!;
            BinaryTreeNode<T> parent = null!;

            while (current != null)
            {
                parent = current;
                int result = data.CompareTo(current.Data);
                if (result == 0)
                {
                    throw new ArgumentException(
                    $"The node {data} already exists.");
                }
                else if (result < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return parent;
        }

        // Metodo para remover node
        public void Remove(T data)
        {
            Remove(Root!, data);
        }

        private void Remove(BinaryTreeNode<T> node, T data)
        {
            if (node == null)
            {
                throw new ArgumentException(
                $"The node {data} does not exist.");
            }
            else if (data.CompareTo(node.Data) < 0)
            {
                Remove(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                Remove(node.Right, data);
            }
            else
            {
                if (node.Left == null && node.Right == null)
                {
                    ReplaceInParent(node, null!);
                    Count--;
                }
                else if (node.Right == null)
                {
                    ReplaceInParent(node, node.Left!);
                    Count--;
                }
                else if (node.Left == null)
                {
                    ReplaceInParent(node, node.Right);
                    Count--;
                }
                else
                {
                    BinaryTreeNode<T> successor = FindMinimumInSubtree(node.Right);
                    node.Data = successor.Data;
                    Remove(successor, successor.Data!);
                }
            }
        }

        // Metodo auxiliar para substituir o pai
        private void ReplaceInParent(BinaryTreeNode<T> node, BinaryTreeNode<T> newNode)
        {
            if (node.Parent != null)
            {
                if (node.Parent.Left == node)
                {
                    node.Parent.Left = newNode;
                }
                else
                {
                    node.Parent.Right = newNode;
                }
            }
            else
            {
                Root = newNode;
            }
            if (newNode != null)
            {
                newNode.Parent = node.Parent!;
            }
        }

        private BinaryTreeNode<T> FindMinimumInSubtree(BinaryTreeNode<T> node)
        {
            // O lado esquerdo possui numeros menores
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        // Parte da busca
        // PreOrder
        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        // InOrder
        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        // Post Order
        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        // Melhorando a visualizacao com enum 
        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root!, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root!, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root!, nodes);
                    break;
            }
            return nodes;
        }

        public enum TraversalEnum
        {
            PREORDER,
            INORDER,
            POSTORDER
        }

        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node
            in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }
    }
}
