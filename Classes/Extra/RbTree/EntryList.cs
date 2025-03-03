using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RbTree
{
    public class EntryList<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public bool IsRed { get; set; }
        public EntryList<T>? Left { get; set; }
        public EntryList<T>? Right { get; set; }
        public EntryList<T>? Parent { get; set; }

        public EntryList(T data)
        {
            Data = data;
            IsRed = true; // Todo nó novo é vermelho por padrão
            Left = null;
            Right = null;
            Parent = null;
        }

        public override string ToString()
        {
            return $"{Data} ({(IsRed ? "Red" : "Black")})";
        }
    }
}