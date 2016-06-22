using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            else
            {
                if (p.val != q.val)
                {
                    return false;
                }

                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }
    }
}
