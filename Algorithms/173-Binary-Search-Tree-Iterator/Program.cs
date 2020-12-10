using System;
using System.Text;

namespace _173_Binary_Search_Tree_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new TreeNode(7, new TreeNode(3),
            new TreeNode(15, new TreeNode(9), new TreeNode(20)));
            var iterator = new BSTIterator(node);
            Console.WriteLine(iterator.Next());    // return 3
            Console.WriteLine(iterator.Next());    // return 7
            Console.WriteLine(iterator.HasNext()); // return True
            Console.WriteLine(iterator.Next());    // return 9
            Console.WriteLine(iterator.HasNext()); // return True
            Console.WriteLine(iterator.Next());    // return 15
            Console.WriteLine(iterator.HasNext()); // return True
            Console.WriteLine(iterator.Next());    // return 20
            Console.WriteLine(iterator.HasNext()); // return False
        }
    }
}
