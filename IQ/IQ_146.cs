using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_146
    {

        private int capacity;
        private Dictionary<int, Node> map;
        private Node header;
        private Node tailer;
        public IQ_146(int capacity)
        {
            this.capacity = capacity;
            this.map = new Dictionary<int, Node>();
            this.header = new Node(-1, -1, null, null);
            this.tailer = new Node(-1, -1, null, null);

            this.header.right = this.tailer;
            this.tailer.left = this.header;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                node.left.right = node.right;
                node.right.left = node.left;

                node.left = header;
                node.right = header.right;
                header.right.left = node;
                header.right = node;

                return node.value;
            }
            else
            {
                return -1;
            }
        }

        public void Set(int key, int value)
        {

            if (!map.ContainsKey(key) && map.Count() >= capacity)
            {
                Node removeNode = tailer.left;
                removeNode.left.right = tailer;
                tailer.left = removeNode.left;
                removeNode.left = null;
                removeNode.right = null;
                map.Remove(removeNode.key);
            }

            if (map.ContainsKey(key))
            {
                Node node = map[key];
                node.value = value;
                node.left.right = node.right;
                node.right.left = node.left;

                node.left = header;
                node.right = header.right;
                header.right.left = node;
                header.right = node;
            }
            else
            {
                Node node = new Node(key, value, header, header.right);
                header.right = node;
                node.right.left = node;

                map.Add(key, node);
            }
        }
    }

    class Node
    {
        public Node(int key, int value, Node left, Node right)
        {
            this.key = key;
            this.value = value;
            this.left = left;
            this.right = right;
        }
        public int key;
        public int value;
        public Node left;
        public Node right;

    }
}
