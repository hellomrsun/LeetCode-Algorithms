using System;

namespace _337_House_Robber_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var node =
                new TreeNode(3,
                    new TreeNode(4, new TreeNode(1), new TreeNode(3)),
                    new TreeNode(5, null, new TreeNode(1)));
            var res = new Solution().Rob(node);
            Console.WriteLine(res);
        }
    }
}
