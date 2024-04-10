using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structuri
{
    internal class Tail<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }   
        int Count;

        public Tail()
        {
            First = Last = null;
            Count = 0;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if(First == null) 
            { 
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }
        public void Remove()
        {
            Node<T> temp = First.Next;
            First.Next = null;
            First = temp;
            Count--;
        }
        public void Print()
        {
            Node<T> curr = First;
            while(curr != null)
            {
                Console.Write(curr.Value + " ");
                curr = curr.Next;
            }
            Console.WriteLine();    
        }
        public int Lenght()
        {
            return Count;
        }
    }
}
