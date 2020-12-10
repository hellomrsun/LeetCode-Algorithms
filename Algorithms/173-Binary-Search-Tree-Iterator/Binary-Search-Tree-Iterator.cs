using System.Collections.Generic;
using System.Linq;

namespace _173_Binary_Search_Tree_Iterator
{
    public class BSTIterator
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            PushAll(root);
        }

        public int Next()
        {
            var curr = stack.Pop();
            if (curr.right != null) PushAll(curr.right);
            return curr.val;
        }

        public bool HasNext()
        {
            return stack.Count() > 0;
        }

        private void PushAll(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
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