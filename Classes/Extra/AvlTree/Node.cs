using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvlTree
{
    public class Node<T>
    {
        public T ?Data { get; set; }         
        public Node<T> Left, Right;  
        public int Height;     

        // Inicializa com o valor e altura 1
        public Node(T data)
        {
            Data = data;
            Height = 1;
            Left = null!;
            Right = null!;
        }
    }
}