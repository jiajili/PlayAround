using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;

            if ((left == null && right != null) || (left != null && right == null) || (left.val != right.val))
                return false;

            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
