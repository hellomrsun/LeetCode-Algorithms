public class Solution {
    public int GetMinimumDifference(TreeNode root) {
        GetMinDiff(root);
        return min;
    }
    
    private int min = int.MaxValue;
    private TreeNode pre;
    
    private void GetMinDiff(TreeNode root){
        if(root == null) return;
        
        GetMinDiff(root.left);
        
        if(pre != null){
            min = Math.Min(min, root.val - pre.val);
        }
        pre = root;
        
        GetMinDiff(root.right);
    }
}

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */