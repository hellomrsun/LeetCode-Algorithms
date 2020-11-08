using System;

namespace _563_Binary_Tree_Tilt
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode  node = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(5)), new TreeNode(9, null, new TreeNode(7)));
            
            int result = new Solution().FindTilt(node);

            Console.WriteLine(result);
        }
    }
}
