using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_127
    {
        public int LadderLength(string beginWord, string endWord, ISet<string> wordList)
        {
            if (wordList.Count == 0) return 0;

            Queue<string> wordQueue = new Queue<string>();
            Queue<int> distanceQueue = new Queue<int>();

            wordQueue.Enqueue(beginWord);
            distanceQueue.Enqueue(1);

            while (wordQueue.Count > 0)
            {
                string currentWord = wordQueue.Dequeue();
                int currentDistance = distanceQueue.Dequeue();

                if (string.Equals(currentWord, endWord))
                {
                    return currentDistance;
                }

                for (int i = 0; i < currentWord.Length; i++)
                {
                    char[] currentChars = currentWord.ToCharArray();

                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        currentChars[i] = c;

                        string newWord = new string(currentChars);

                        if (string.Equals(newWord, endWord))
                        {
                            return currentDistance + 1;
                        }

                        if (wordList.Contains(newWord))
                        {
                            wordQueue.Enqueue(newWord);
                            distanceQueue.Enqueue(currentDistance + 1);
                            wordList.Remove(newWord);
                        }
                    }
                }
            }


            return 0;
        }
    }
}
