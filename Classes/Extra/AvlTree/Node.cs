using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvlTree
{
    public class Node<T>
    {
        public T Value;         
        public Node<T> Left, Right;  
        public int Height;     

        // Inicializa com o valor e altura 1
        public Node(T value)
        {
            Value = value;
            Height = 1;
        }
    }
}