using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularLinkedLists{
    public class CircularLinkedListEnumerator<T> : IEnumerator<T>{
        private LinkedListNode<T> _current;
        public T Current => _current.Value;
        object IEnumerator.Current => Current;
        public CircularLinkedListEnumerator(LinkedList<T> list){_current = list.First;}
        public bool MoveNext(){
            if (_current == null){
                return false;
            }
            _current = _current.Next ?? _current.List.First;
            return true;
        }
        public void Reset(){
            _current = _current.List.First;
        }
        public void Dispose() { }
    }
}