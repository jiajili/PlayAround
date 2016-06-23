using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_171
    {
        public int TitleToNumber(string s)
        {
            long ret = 0;

            for (int i = 0; i < s.Length; i++)
            {
                ret *= 26;
                ret += (s[i] - 'A' + 1);
            }

            if (ret > int.MaxValue)
            {
                return int.MaxValue;
            }

            return (int)ret;
        }
    }
}
