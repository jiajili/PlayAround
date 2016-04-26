using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// Palindrome Number
    /// Determine whether an integer is a palindrome. Do this without extra space.
    /// </summary>
    public class IQ_009
    {
        public bool IsPalindrome(int x)
        {
            if (x == int.MinValue) return false;

            long y = Math.Abs(x);
            long k = 0;

            while (y > 0)
            {
                k *= 10;
                k += (y % 10);
                y /= 10;
            }

            if (k > int.MaxValue) return false;

            return x == (int)k ? true : false;
        }
    }
}
