using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ret = new List<IList<int>>();

            if (root == null) return ret;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                IList<int> levelList = new List<int>();
                Queue<TreeNode> nextLevelQueue = new Queue<TreeNode>();

                foreach (var item in queue)
                {
                    levelList.Add(item.val);
                    if (item.left != null)
                    {
                        nextLevelQueue.Enqueue(item.left);
                    }

                    if (item.right != null)
                    {
                        nextLevelQueue.Enqueue(item.right);
                    }
                }

                ret.Add(levelList);
                queue = nextLevelQueue;
            }

            return ret;

        }
    }
}
