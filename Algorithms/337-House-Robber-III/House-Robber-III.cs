using System;

namespace _337_House_Robber_III
{
    public class Solution
    {
        public int Rob(TreeNode root)
        {
            int[] res = RobSub(root);
            return Math.Max(res[0], res[1]);
        }

        private int[] RobSub(TreeNode node)
        {
            if (node == null) return new int[2];

            int[] left = RobSub(node.left);
            int[] right = RobSub(node.right);
            int[] res = new int[2];

            res[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            res[1] = node.val + left[0] + right[0];

            return res;
        }
    }

    public class TreeNode
    {
        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(
            int val = 0,
            TreeNode left = null,
            TreeNode right = null
        )
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
