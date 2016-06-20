using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.Common
{
    public class TrieNode
    {
        // Initialize your data structure here.

        public char Value { get; set; }
        public Dictionary<char, TrieNode> Children { get; private set; }
        public bool IsLeaf { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsLeaf = false;
        }
    }
}
