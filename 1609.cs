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
public class Solution
{   
    public bool IsEvenOddTree(TreeNode root)
    {
        if (root == null)
            return true;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isEvenLevel = true;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            int prevValue = isEvenLevel ? int.MinValue : int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();

                if (isEvenLevel)
                {
                    if (current.val % 2 == 0 || current.val <= prevValue)
                        return false;
                }
                else
                {
                    if (current.val % 2 != 0 || current.val >= prevValue)
                        return false;
                }

                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);

                prevValue = current.val;
            }

            isEvenLevel = !isEvenLevel;
        }

        return true;
    }
}
