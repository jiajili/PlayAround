using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_208
    {
        private TrieNode root;

        public IQ_208()
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void Insert(String word)
        {

            TrieNode currentNode = root;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (currentNode.Children.ContainsKey(c))
                {
                    currentNode = currentNode.Children[c];
                }
                else
                {
                    var trieNode = new TrieNode();
                    trieNode.Value = c; 
                    currentNode.Children.Add(c, trieNode);
                    currentNode = trieNode;
                }

                if (i == word.Length - 1)
                {
                    currentNode.IsLeaf = true;
                }

            }
        }

        // Returns if the word is in the trie.
        public bool Search(string word)
        {
            var children = root.Children;
            for (int i = 0; i < word.Length; i++)
            {
                if (!children.ContainsKey(word[i]))
                {
                    return false;
                }

                var currentTrieNode = children[word[i]];
                if ((i == word.Length - 1) && currentTrieNode.IsLeaf) return true;

                children = currentTrieNode.Children;
            }

            return false;
        }

        // Returns if there is any word in the trie
        // that starts with the given prefix.
        public bool StartsWith(string word)
        {
            var children = root.Children;
            for (int i = 0; i < word.Length; i++)
            {
                if (!children.ContainsKey(word[i]))
                {
                    return false;
                }

                var currentTrieNode = children[word[i]];
                children = currentTrieNode.Children;
            }

            return true;
        }
    }


    class TrieNode
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
