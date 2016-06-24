using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                var tempNode = node.left;
                node.left = node.right;
                node.right = tempNode;
            }

            return root;
        }
    }
}
