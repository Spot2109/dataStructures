using Stek;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stek<int> stek = new Stek<int>();
            Tail<int> tail = new Tail<int>();
            ArrayStek<int> stek1 = new ArrayStek<int>();

            stek.Add(1);
            stek.Add(2);
            stek.Add(3);
            stek.Add(4);
            stek.Add(5);
            stek.Print();       
            stek.Remove();
            stek.Print();
            Console.WriteLine();
            //Console.WriteLine(stek.Lenght());

            tail.Add(1);
            tail.Add(2);
            tail.Add(3);
            tail.Add(4);
            tail.Add(5);
            tail.Print();
            tail.Remove();
            tail.Print();
            Console.WriteLine();

            stek1.Add(1);
            stek1.Add(2);
            stek1.Add(3);
            stek1.Add(4);
            stek1.Add(5);
            stek1.Print();
            stek1.Remove();
            stek1.Print();
        }
    }
}
