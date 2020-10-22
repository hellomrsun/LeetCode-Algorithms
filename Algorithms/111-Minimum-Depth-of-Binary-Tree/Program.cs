using System;

namespace _111_Minimum_Depth_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n2 = new TreeNode(2, new TreeNode(3));
            var n5 = new TreeNode(5, new TreeNode(6, new TreeNode(11)), new TreeNode(7));
            var n8 = new TreeNode(8, new TreeNode(9), new TreeNode(10));
            var node = new TreeNode(1, n2, new TreeNode(4, n5, n8));

            var result = new Solution().MinDepth(node);
            Console.WriteLine("The minimum depth of binary tree is:" + result);
        }
    }
}
