using System;

namespace _865_Smallest_Subtree_with_all_the_Deepest_Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new TreeNode(3,
                new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))),
                new TreeNode(1, new TreeNode(0), new TreeNode(8)));
            var res = new Solution().SubtreeWithAllDeepest(node);
            Console.WriteLine($"root:{res.val}, left:{res.left.val}, right:{res.right.val}.");
        }
    }
}
