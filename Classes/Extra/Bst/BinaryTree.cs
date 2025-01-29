using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> ?Root { get; set; }
        public int Count { get; set; }
    }
}