using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>();
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                // Verifica se a lista `Children` contém pelo menos 1 elemento
                if (Children != null && Children.Count > 0)
                {
                    return (BinaryTreeNode<T>)Children[0];
                }
                return null!;
            }
            set
            {
                // Garante que a lista Children esteja inicializada
                if (Children == null)
                {
                    Children = new List<TreeNode<T>>();
                }

                // Verifica se há espaço para o índice 0, adicionando se necessário
                if (Children.Count == 0)
                {
                    Children.Add(value);
                }
                else
                {
                    Children[0] = value;
                }
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                // Verifica se a lista `Children` contém pelo menos 2 elementos
                if (Children != null && Children.Count > 1)
                {
                    return (BinaryTreeNode<T>)Children[1];
                }
                return null!; // Retorna null se não houver filho direito
            }
            set
            {
                // Garante que a lista Children esteja inicializada
                if (Children == null)
                {
                    Children = new List<TreeNode<T>>();
                }

                // Verifica se há espaço para o índice 1, adicionando se necessário
                if (Children.Count == 1)
                {
                    Children.Add(value);
                }
                else if (Children.Count > 1)
                {
                    Children[1] = value;
                }
            }
        }
    }
}
