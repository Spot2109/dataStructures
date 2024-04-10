using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structuri
{
    internal class Stek<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        
        int Count;
        public Stek() 
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public void Add(T Value) 
        { 
            Node<T> newNode = new Node<T>(Value);

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
            Node<T> curr = First;

            while(curr.Next != Last)
            {
                curr = curr.Next;
            }
            curr.Next = null;
            Count--;
        }
        public void Print() 
        { 
            Node<T> node = First;
            while (node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }
        public int Lenght()
        {
            return Count;
        }
    }
}
