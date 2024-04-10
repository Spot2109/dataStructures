using System;
using TreeProject;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(8,
                                new Tree<int>(3,
                                    new Tree<int> (11,
                                        new Tree<int> (15),
                                        new Tree<int> (16))), 
                                new Tree<int>(4,
                                    new Tree<int>(2,
                                        new Tree<int>(21)),
                                    new Tree<int> (6)));
                                  

            tree.BFS();
            Console.WriteLine();
            tree.DFS();
        }
    }
}
