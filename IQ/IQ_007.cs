using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// Reverse digits of an integer.
    /// Example1: x = 123, return 321
    /// Example2: x = -123, return -321     
    /// </summary>
    public class IQ_007
    {
        public int Reverse(int x)
        {
            long k = x;
            var isNegative = false;
            if (k < 0)
            {
                k = 0 - k;
                isNegative = true;
            }

            long result = 0;
            while (k != 0)
            {
                result *= 10;
                result += k % 10;
                k /= 10;
            }

            if (result > int.MaxValue) return 0;
            return isNegative ? 0 - ((int)result) : (int)result;
        }
    }
}
