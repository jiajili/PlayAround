using PlayAround.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_257
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> finalResult = new List<string>();
            if (root == null) return finalResult;

            IList<string> current = new List<string>();
            IList<IList<string>> result = new List<IList<string>>();

            DFS(root, current, result);

            foreach (var item in result)
            {
                if (item.Count == 1)
                {
                    finalResult.Add(item[0]);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < item.Count - 1; i++)
                    {
                        sb.Append(item[i] + "->");
                    }

                    sb.Append(item[item.Count - 1]);

                    finalResult.Add(sb.ToString());
                }
            }

            return finalResult;
        }

        private void DFS(TreeNode node, IList<string> current, IList<IList<string>> result)
        {
            current.Add(node.val.ToString());
            if (node.left == null && node.right == null)
            {
                result.Add(current);
                return;
            }

            if (node.left != null)
            {
                IList<string> copy = new List<string>(current);
                DFS(node.left, copy, result);
            }

            if (node.right != null)
            {
                IList<string> copy = new List<string>(current);
                DFS(node.right, copy, result);
            }
        }
    }
}
