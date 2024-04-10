using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stek
{
    internal class ArrayStek<T>
    {
        private static readonly int init = 4;
        object[] Array;
        int Count;
        public ArrayStek() 
        {
            Array = new object[init];
            Count = 0;
        }
        public void Add(T item)
        {
            object[] array = Array;

            if (Array.Length == Count)
            {
                array = new object[Array.Length * 2];
            }

            for (int i = 0; i < Count; i++)
            {
                array[i] = Array[i]; 
            }
            Count++;
            array[Count - 1] = item;
            Array = array;
        }
        public void Remove() 
        {
            object[] array = new object[Array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Array[i];
            }
            Array = array;
            Count--;
        }
        public void Print() 
        {
            for(int i = 0; i < Count; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
