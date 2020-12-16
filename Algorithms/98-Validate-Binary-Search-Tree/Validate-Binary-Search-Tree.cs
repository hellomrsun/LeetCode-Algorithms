namespace _98_Validate_Binary_Search_Tree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return Dfs(root, null, null);
        }

        private bool Dfs(TreeNode root, int? min, int? max)
        {
            if (root == null) return true;

            if (max != null && root.val >= max.Value) return false;
            if (min != null && root.val <= min.Value) return false;

            if (!Dfs(root.left, min, root.val)) return false;
            if (!Dfs(root.right, root.val, max)) return false;

            return true;
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