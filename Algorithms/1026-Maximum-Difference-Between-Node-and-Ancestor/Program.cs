using System;

namespace _1026_Maximum_Difference_Between_Node_and_Ancestor
{
    class Program
    {
        static void Main(string[] args)
        {
            var node =
                new TreeNode(8,
                    new TreeNode(3,
                        new TreeNode(1),
                        new TreeNode(6, new TreeNode(4), new TreeNode(7))),
                    new TreeNode(10, null, new TreeNode(14, new TreeNode(13))));
            var res = new Solution().MaxAncestorDiff(node);

            Console.WriteLine (res);
        }
    }
}
