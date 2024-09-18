using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularLinkedLists
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
       public new IEnumerator GetEnumerator(){
            return new CircularLinkedListEnumerator<T>(this);
        } 
    }
}