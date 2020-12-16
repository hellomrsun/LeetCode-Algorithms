using System;

namespace _98_Validate_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
            var res = new Solution().IsValidBST(node);
            Console.WriteLine(res);
        }
    }
}
