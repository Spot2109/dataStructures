using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    internal class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree(T value, params Tree<T>[] subtrees)
        {
            Root = new TreeNode<T>(value);

            foreach (var subtree in subtrees)
            {
                Root.Children.Add(subtree.Root);
            }
        }

        public void BFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                TreeNode<T> curr = queue.Dequeue();
                Console.WriteLine(curr.Value + " ");

                foreach (var subtree in curr.Children) 
                {
                    queue.Enqueue(subtree);
                }
            }
        }
        public void DFS()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(Root);

            while(stack.Count > 0)
            {
                TreeNode<T> curr = stack.Pop();
                Console.WriteLine(curr.Value + " ");

                for (int i = curr.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(curr.Children[i]);
                }
            }
        }
    }
}
