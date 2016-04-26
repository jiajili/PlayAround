using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    public class IQ_008
    {
        /// <summary>
        /// https://leetcode.com/problems/string-to-integer-atoi/
        /// Implement atoi to convert a string to an integer.
        /// Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself 
        /// what are the possible input cases. Notes: It is intended for this problem to be specified vaguely 
        /// (ie, no given input specs). You are responsible to gather all the input requirements up front.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;

            double ret = 0;
            bool isNegative = false;
            str = str.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                var k = str[i];
                if (k == '-' && i == 0)
                {
                    isNegative = true;
                    continue;
                }

                if (k == '+' && i == 0)
                {
                    continue;
                }

                if (k < '0' || k > '9')
                {
                    break;
                }

                ret *= 10;
                ret += (k - '0');
            }


            ret = isNegative ? -ret : ret;

            if (ret > int.MaxValue)
            {
                return int.MaxValue;
            }
            if (ret < int.MinValue)
            {
                return int.MinValue;
            }
            return (int)ret;
        }
    }
}
