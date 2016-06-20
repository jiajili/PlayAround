using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_211
    {
        private RegexTrie trie = new RegexTrie();
        // Adds a word into the data structure.
        public void AddWord(String word)
        {
            trie.Insert(word);
        }

        // Returns if the word is in the data structure. A word could
        // contain the dot character '.' to represent any one letter.
        public bool Search(string word)
        {
            return trie.Search(word);
        }
    }

    class RegexTrie
    {
        private TrieNode root;

        public RegexTrie()
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
            return DFSSearch(root.Children, word, 0);
        }

        private bool DFSSearch(Dictionary<char, TrieNode> children, string word, int start)
        {
            if (start == word.Length)
            {
                if (children.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            char c = word[start];

            if (children.ContainsKey(c))
            {
                if ((start == word.Length - 1) && children[c].IsLeaf)
                {
                    return true;
                }

                return DFSSearch(children[c].Children, word, start + 1);
            }
            else if (c == '.')
            {
                bool result = false;

                foreach (var child in children)
                {
                    if ((start == word.Length - 1) && child.Value.IsLeaf)
                    {
                        return true;
                    }

                    if (DFSSearch(child.Value.Children, word, start + 1))
                    {
                        result = true;
                    }
                }

                return result;
            }
            else
            {
                return false;
            }
        }           
    }
}
