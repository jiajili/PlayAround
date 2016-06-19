using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_344
    {
        public string ReverseString(string s)
        {
            if (null == s || s.Length <= 1) return s;
            var char_arr = s.ToCharArray();

            int halfLength = char_arr.Length/2;

            for (int i = 0; i < halfLength; i++)
            {
                char c = char_arr[char_arr.Length -i - 1];
                char_arr[char_arr.Length - i - 1] = char_arr[i];
                char_arr[i] = c;
            }

            return new string(char_arr);
        }
    }
}
