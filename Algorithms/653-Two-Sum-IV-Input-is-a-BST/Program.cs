using System;

namespace _653_Two_Sum_IV_Input_is_a_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            var n6 = new TreeNode(6, null, new TreeNode(7, null, null));
            var n3 = new TreeNode(3, new TreeNode(2, null, null), new TreeNode(4, null, null));
            var tn = new TreeNode(5, n3, n6);

            var r = new Solution().FindTarget(tn, 9);
            Console.WriteLine("9 can be a sum of two nodes in the tree? Result:" + r);
        }
    }
}
