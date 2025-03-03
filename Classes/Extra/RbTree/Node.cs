using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RbTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public bool IsRed { get; set; }
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }

        public Node(T data)
        {
            Data = data;
            IsRed = true; // Todo novo nó começa como vermelho
            Left = null;
            Right = null;
        }
    }
}