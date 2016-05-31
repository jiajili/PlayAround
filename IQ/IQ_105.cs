using PlayAround.Common;
using System;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// 
    /// 105. Construct Binary Tree from Preorder and Inorder Traversal
    /// Given preorder and inorder traversal of a tree, construct the binary tree.
    /// Note:
    /// You may assume that duplicates do not exist in the tree.
    /// </summary>
    public class IQ_105
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || preorder.Length == 0 || inorder == null || inorder.Length != preorder.Length) return null;

            int preStart = 0;
            int preEnd = preorder.Length - 1;
            int inStart = 0;
            int inEnd = inorder.Length - 1;

            return this.Construct(preorder, preStart, preEnd, inorder, inStart, inEnd);
        }

        public TreeNode Construct(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
        {
            if (preStart > preEnd || inStart > inEnd)
            {
                return null;
            }

            int val = preorder[preStart];
            TreeNode p = new TreeNode(val);

            // try using BinarySearch to find the element?
            //find parent element index from inorder
            //int k = Array.BinarySearch(inorder, val);

            // or putting all inorder elements into a Dictionary in order to find an element quickly O(1)?

            //find parent element index from inorder
            int k = 0;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (val == inorder[i])
                {
                    k = i;
                    break;
                }
            }
           
            p.left = Construct(preorder, preStart + 1, preStart + (k - inStart), inorder, inStart, k - 1);
            p.right = Construct(preorder, preStart + (k - inStart) + 1, preEnd, inorder, k + 1, inEnd);

            return p;
        }
    }
}
