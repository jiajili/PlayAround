namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// Given a string S, find the longest palindromic substring in S. 
    /// You may assume that the maximum length of S is 1000, and there exists one unique longest palindromic substring.
    /// </summary>
    public class IQ_005
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0)
                return "";
            string longest = s.Substring(0, 1); // a single char itself is a
                                                // palindrome
            for (int i = 0; i < n - 1; i++)
            {
                string p1 = expandAroundCenter(s, i, i);
                if (p1.Length > longest.Length)
                    longest = p1;

                string p2 = expandAroundCenter(s, i, i + 1);
                if (p2.Length > longest.Length)
                    longest = p2;
            }
            return longest;
        }

        private string expandAroundCenter(string s, int c1, int c2)
        {
            int l = c1, r = c2;
            int n = s.Length;
            while (l >= 0 && r <= n - 1 && s[l] == s[r])
            {
                l--;
                r++;
            }
            return s.Substring(l + 1, r - l - 1);
        }
    }
}
