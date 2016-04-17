using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// Given a string, find the length of the longest substring without repeating characters.
    ///Examples:
    ///Given "abcabcbb", the answer is "abc", which the length is 3.
    ///Given "bbbbb", the answer is "b", with the length of 1.
    ///Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, 
    ///"pwke" is a subsequence and not a substring.
    /// </summary>
    public class IQ_003
    {
        public int LengthOfLongestSubstring(string s)
        {
            int longest = 0;
            HashSet<char> set = new HashSet<char>();
            int start = 0;
            int end = 0;

            while (end < s.Length)
            {
                if(!set.Contains(s[end])){
                    set.Add(s[end++]);
                    longest = Math.Max(longest, set.Count());
                }else{
                    while(s[start]!=s[end]){                        
                        set.Remove(s[start++]);
                    }
                    start++;
                    end++;
                }
            }

            return longest;
        }
    }
}
