using System;
using System.Collections.Generic;

namespace _865_Smallest_Subtree_with_all_the_Deepest_Nodes
{
    public class Solution
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            return Height(root).Value;
        }

        private KeyValuePair<int, TreeNode> Height(TreeNode node)
        {
            if (node == null) return new KeyValuePair<int, TreeNode>(0, null);

            KeyValuePair<int, TreeNode> left = Height(node.left);
            KeyValuePair<int, TreeNode> right = Height(node.right);

            int leftHeight = left.Key;
            int rightHeight = right.Key;

            if (leftHeight == rightHeight)
            {
                return new KeyValuePair<int, TreeNode>(leftHeight + 1, node);
            }
            else if (leftHeight < rightHeight)
            {
                return new KeyValuePair<int, TreeNode>(rightHeight + 1, right.Value);
            }
            else
            {
                return new KeyValuePair<int, TreeNode>(leftHeight + 1, left.Value);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}