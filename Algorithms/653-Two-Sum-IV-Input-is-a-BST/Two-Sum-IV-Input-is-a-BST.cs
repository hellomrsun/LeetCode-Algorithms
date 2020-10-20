using System;
using System.Collections.Generic;

namespace _653_Two_Sum_IV_Input_is_a_BST
{
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var hashset = new HashSet<int>();
            return Dfs(root, k, hashset);
        }

        private bool Dfs(TreeNode root, int k, HashSet<int> hs)
        {
            if (root == null) return false;
            if (hs.Contains(k - root.val)) return true;
            hs.Add(root.val);
            return Dfs(root.left, k, hs) || Dfs(root.right, k, hs);
        }
    }
    /**
     * Definition for a binary tree node.
     */
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