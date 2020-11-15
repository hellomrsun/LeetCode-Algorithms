using System;

namespace _938_Range_Sum_of_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            var node =
                new TreeNode(10,
                    new TreeNode(5,
                        new TreeNode(3, new TreeNode(1)),
                        new TreeNode(7, new TreeNode(6))),
                    new TreeNode(15, new TreeNode(13), new TreeNode(18)));
            var res = new Solution().RangeSumBST(node, 6, 10);
            Console.WriteLine(res);
        }
    }
}
