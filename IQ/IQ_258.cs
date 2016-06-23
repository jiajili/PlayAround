using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_258
    {
        public int AddDigits(int num)
        {
            int sum = 0;
            var s = num.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                sum = sum + (s[i] - '0');
            }

            if (sum < 10)
            {
                return sum;
            }
            else
            {
                return AddDigits(sum);
            }
        }

        public int AddDigits2(int num)
        {
            return num - 9 * ((num - 1) / 9);
        }
    }
}
